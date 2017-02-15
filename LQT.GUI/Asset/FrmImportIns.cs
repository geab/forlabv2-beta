﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LQT.Core.Util;
using LQT.Core.Domain;

namespace LQT.GUI.Asset
{
    public partial class FrmImportIns : Form
    {
        private IList<ImportInsData> _rdata;
        public FrmImportIns()
        {
            InitializeComponent();
        }

        private void butBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                txtFilename.Text = openFileDialog1.FileName;
            }
        }

        private void butImport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilename.Text.Trim()))
                return;
            try
            {
                DataSet ds = LqtUtil.ReadExcelFile(txtFilename.Text, 8);

                _rdata = GetDataRow(ds);
                bool haserror = false;

                lvImport.BeginUpdate();
                lvImport.Items.Clear();
                string errorString;

                foreach (ImportInsData rd in _rdata)
                {
                    string str;
                    errorString = "";
                    ListViewItem li = new ListViewItem(rd.RowNo.ToString());
                    li.SubItems.Add(rd.TestingArea != null ?rd.TestingArea.AreaName: rd.AreaName);
                    li.SubItems.Add(rd.InsName);                    
                    li.SubItems.Add(rd.Rate.ToString());
                    li.SubItems.Add(rd.PerTestCtr.ToString());
                    li.SubItems.Add(rd.DailyCtrTest.ToString());
                    li.SubItems.Add(rd.WeeklyCtrTest.ToString());
                    li.SubItems.Add(rd.MonthlyCtrTest.ToString());
                    li.SubItems.Add(rd.QuarterlyCtrTest.ToString());
                    
                    str = rd.IsExist ? "Yes" : "No";

                    if (!rd.HasError)
                    {
                        foreach (ListViewItem Item in lvImport.Items)
                        {
                            if (Item.SubItems[1].Text.Trim() == rd.TestingArea.AreaName.Trim() && Item.SubItems[2].Text.Trim() == rd.InsName.Trim())
                            {
                                rd.IsExist = true;
                                str = "Duplicated";
                                break;
                            }

                        }
                    }
                    li.SubItems.Add(str); 

                    if (rd.HasError)
                    {
                        if(rd.TestingArea==null)
                            errorString = errorString + " Testing Area Required";
                        if(rd.InsName=="")
                            errorString = errorString + " Instrument Name Required";
                        li.BackColor = Color.Red;
                        haserror = true;
                    }
                    else if (rd.IsExist)
                    {
                        li.BackColor = Color.Yellow;
                    }
                    li.SubItems.Add(errorString);
                    lvImport.Items.Add(li);
                }

                lvImport.EndUpdate();

                butClear.Enabled = true;
                if (!haserror)
                    butSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Importing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            lvImport.BeginUpdate();
            lvImport.Items.Clear();
            lvImport.EndUpdate();
            butSave.Enabled = false;
            butClear.Enabled = false;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            int count = 0;
            int error = 0;
            try
            {
                foreach (ImportInsData rd in _rdata)
                {
                    if (!rd.IsExist)
                    {
                        Instrument ins = new Instrument();

                        ins.InstrumentName = rd.InsName;
                        ins.MaxThroughPut = rd.Rate;
                       // ins.MonthMaxTPut = (rd.Rate * 5) * 22;
                        ins.TestingArea = rd.TestingArea;
                        ins.DailyCtrlTest = rd.DailyCtrTest;
                        ins.WeeklyCtrlTest = rd.WeeklyCtrTest;
                        ins.MonthlyCtrlTest = rd.MonthlyCtrTest;
                        ins.QuarterlyCtrlTest = rd.QuarterlyCtrTest;
                        ins.MaxTestBeforeCtrlTest = rd.PerTestCtr;
                        count++;
                        DataRepository.SaveOrUpdateInstrument(ins);

                        if (rd.TestingArea.UseInDemography)
                        {
                            if (rd.TestingArea.ClassOfTestToEnum == ClassOfMorbidityTestEnum.CD4 ||
                                rd.TestingArea.ClassOfTestToEnum == ClassOfMorbidityTestEnum.Chemistry ||
                                rd.TestingArea.ClassOfTestToEnum == ClassOfMorbidityTestEnum.Hematology ||
                                rd.TestingArea.ClassOfTestToEnum == ClassOfMorbidityTestEnum.ViralLoad)
                            {
                                MorbidityTest mtest = new MorbidityTest();
                                mtest.Instrument = ins;
                                mtest.ClassOfTest = rd.TestingArea.Category;
                                mtest.TestName = ManageQuantificationMenus.BuildTestName(ins.InstrumentName, mtest.ClassOfTestEnum);
                                ManageQuantificationMenus.CreateQuantifyMenus(mtest);

                                DataRepository.SaveOrUpdateMorbidityTest(mtest);
                            }
                        }
                    }
                    else { error++; }

                }

                MessageBox.Show(count + " Instruments are imported and saved successfully." + Environment.NewLine + error + " Instruments Failed.", "Importing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();

            }
            catch
            {
                MessageBox.Show("Error: Unable to import and save Instrument data.", "Importing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DataRepository.CloseSession();
            }
        }

        IDictionary<string, ImportedTestingArea> _listOfImportedTA = new Dictionary<string, ImportedTestingArea>();
        private void AddImportedTestingArea(ImportedTestingArea impTa)
        {
            if (!_listOfImportedTA.ContainsKey(impTa.AreaName))
                _listOfImportedTA.Add(impTa.AreaName, impTa);
        }

        private IList<ImportInsData> GetDataRow(DataSet ds)
        {
            int rowno = 0;
            IList<ImportInsData> rdlist = new List<ImportInsData>();
            int maxThroughput, dailyTest, perTestCtrl, weeklyTest, monthlyTest, quarterlyTest;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rowno++;
                if (!DatarowValueToInt(dr[2], out maxThroughput))
                    maxThroughput = 1;
                if (!DatarowValueToInt(dr[3], out perTestCtrl))
                    perTestCtrl = 0;
                if (!DatarowValueToInt(dr[4], out dailyTest))
                    dailyTest = 0;
                if (!DatarowValueToInt(dr[5], out weeklyTest))
                    weeklyTest = 0;
                if (!DatarowValueToInt(dr[6], out monthlyTest))
                    monthlyTest = 0;
                if (!DatarowValueToInt(dr[7], out quarterlyTest))
                    quarterlyTest = 0;

                ImportInsData rd = new ImportInsData(Convert.ToString(dr[1]).Trim(), Convert.ToString(dr[0]).Trim(), maxThroughput, dailyTest, weeklyTest, monthlyTest, quarterlyTest, perTestCtrl, rowno);
                if (!string.IsNullOrEmpty(Convert.ToString(dr[0])))
                    AddImportedTestingArea(new ImportedTestingArea(Convert.ToString(dr[0]).Trim()));

                rdlist.Add(rd);
            }

            FrmAssignTestingArea frm = new FrmAssignTestingArea(_listOfImportedTA);
            frm.ShowDialog();

            foreach (ImportInsData rd in rdlist)
            {
                if (!string.IsNullOrEmpty(rd.AreaName))
                {
                    ImportedTestingArea ita = _listOfImportedTA[rd.AreaName.Trim()];
                    rd.TestingArea = ita.TestingArea;

                    if (!string.IsNullOrEmpty(rd.InsName))
                    {
                        rd.IsExist = DataRepository.GetInstrumentByNameAndTestingArea(rd.InsName.Trim(), rd.TestingArea.Id) != null;
                    }
                    else
                        rd.HasError = true;
                }
                else
                    rd.HasError = true;
            }

            return rdlist;
        }

        private bool DatarowValueToInt(object drvalue, out int result)
        {
            return Int32.TryParse(Convert.ToString(drvalue), out result);
        }
        private class ImportInsData
        {
            private string _insname;
            private string _areaname;
            private int _rate;
            private int _rowno;
            private bool _haserror = false;
            private bool _isexist = false;
            private TestingArea _testingArea;
            private int _dailyCtrTest;
            private int _weeklyCtrTest;
            private int _monthlyCtrTest;
            private int _quarterlyCtrTest;
            private int _perTestCtr;

            public ImportInsData(string iname, string areaname, int mput, int dailyCtrTest, int weeklyCtrTest, int monthlyCtrTest, int quareterlyCtrTest, int perTestCtr, int rowno)
            {
                _insname = iname;
                _areaname = areaname;
                _rate = mput;
                _rowno = rowno;
                _dailyCtrTest = dailyCtrTest;
                _weeklyCtrTest = weeklyCtrTest;
                _monthlyCtrTest = monthlyCtrTest;
                _quarterlyCtrTest = quareterlyCtrTest;
                _perTestCtr = perTestCtr;
            }

            public string InsName
            {
                get { return _insname; }
            }

            public string AreaName
            {
                get { return _areaname; }
            }

            public TestingArea TestingArea
            {
                get { return _testingArea; }
                set { _testingArea = value; }
            }

            public int Rate
            {
                get { return _rate; }
            }
            public int RowNo
            {
                get { return _rowno; }
            }

            public bool HasError
            {
                get { return _haserror; }
                set { _haserror = value; }
            }

            public bool IsExist
            {
                get { return _isexist; }
                set { _isexist = value; }
            }

            public int DailyCtrTest
            {
                get { return _dailyCtrTest; }
            }
            public int WeeklyCtrTest
            {
                get { return _weeklyCtrTest; }
            }
            public int MonthlyCtrTest
            {
                get { return _monthlyCtrTest; }
            }

            public int QuarterlyCtrTest
            {
                get { return _quarterlyCtrTest; }
            }
            public int PerTestCtr
            {
                get { return _perTestCtr; }
            }
        }
    }

    public class ImportedTestingArea
    {
        private string _areaName;
        private TestingArea _testingArea;

        public ImportedTestingArea(string areaName)
        {
            this._areaName = areaName;
        }

        public string AreaName
        {
            get { return _areaName; }
        }
        public TestingArea TestingArea
        {
            get { return _testingArea; }
            set { _testingArea = value; }
        }
    }
}
