using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LQT.Core.Domain;
using LQT.Core.Util;

namespace LQT.GUI.Testing
{
    public partial class FrmImportTest : Form
    {
        private IList<ImportTestData> _rdata;

        public FrmImportTest()
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
                DataSet ds = LqtUtil.ReadExcelFile(txtFilename.Text, 2);

                _rdata = GetDataRow(ds);
                bool haserror = false;

                lvImport.BeginUpdate();
                lvImport.Items.Clear();
                string errorString;

                foreach (ImportTestData rd in _rdata)
                {
                    ListViewItem li = new ListViewItem(rd.RowNo.ToString());
                    li.SubItems.Add(rd.TestName);                    
                    li.SubItems.Add(rd.AreaName);
                  
                    string str = rd.IsExist? "Yes" : "No";
                    foreach (ListViewItem Item in lvImport.Items)
                    {
                        if (Item.SubItems[0].Text.Trim()  == rd.TestName.Trim() )
                        {
                            rd.IsExist = true;
                            str = "Duplicated";
                        }

                    }
                    li.SubItems.Add(str);
                    errorString = "";
                    if (rd.HasError)
                    {
                        if (rd.TestName == "")
                            errorString = errorString + " Test Name Required";
                        if (rd.AreaName == "")
                            errorString = errorString + " Area Name Required";
                       
                       
                        li.BackColor = Color.Red;
                        haserror = true;
                    }
                    if (rd.IsExist)
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
                foreach (ImportTestData rd in _rdata)
                {
                    if (!rd.IsExist)
                    {
                        Test test = new Test();
                        test.TestName = rd.TestName;
                        test.TestingArea = rd.TestArea;
                       
                        count++;
                        DataRepository.SaveOrUpdateTest(test);
                    }
                    else { error++; }
                }

                MessageBox.Show(count + " Tests are imported and saved successfully." + Environment.NewLine + error + " Tests Failed.", "Importing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error: Unable to imported and saved Test data.", "Importing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DataRepository.CloseSession();
            }
        }

        private IList<ImportTestData> GetDataRow(DataSet ds)
        {
            string testName;
            //string groupName;
            string areaName;
            string aName = "";
           // string gName = "";
            TestingArea testArea = null;
           
            int rowno = 0;
            bool haserror;

            IList<ImportTestData> rdlist = new List<ImportTestData>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rowno++;
                haserror=false;
                testName = Convert.ToString(dr[0]).Trim() ;
                areaName = Convert.ToString(dr[1]).Trim() ;
                //groupName = Convert.ToString(dr[2]).Trim() ;



                ImportTestData rd = new ImportTestData(testName,areaName, rowno);

                if (aName != areaName)
                {
                    if (!string.IsNullOrEmpty(areaName))
                    {
                        testArea = DataRepository.GetTestingAreaByName(areaName);
                        if (testArea == null)
                        {
                            testArea = new TestingArea();
                            testArea.AreaName = areaName;
                            DataRepository.SaveOrUpdateTestingArea(testArea);
                        }
                    }
                    else
                        testArea = null;
                    aName = areaName;
                }
                rd.TestArea = testArea;

                if (testArea != null)
                {

                    if (!string.IsNullOrEmpty(testName))
                        rd.IsExist = DataRepository.GetTestByName(testName) != null;
                    else
                        haserror = true;
                }
                else
                    haserror = true;
                rd.HasError = haserror;

                rdlist.Add(rd);
            }

            return rdlist;
        }

        private DateTime? ConvertStrTodate(string str)
        {
            DateTime? d = null;
            try
            {
                d = DateTime.Parse(str);
            }
            catch { }

            return d;
        }

        private class ImportTestData
        {
            private string _testname;
            //private string _groupname;
            private string _areaname;
            private int _rowno;
            private TestingArea _testarea;
            
            private bool _haserror = false;
            private bool _isexist = false;

            public ImportTestData(string tname,string aname, int rowno)
            {
                _testname = tname;
                //_groupname = gname;
                _areaname = aname;
                _rowno = rowno;
            }

            public string TestName
            {
                get { return _testname; }
            }
            //public string GroupName
            //{
            //    get { return _groupname; }
            //}
            public string AreaName
            {
                get { return _areaname; }
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
            public TestingArea TestArea
            {
                get { return _testarea; }
                set { _testarea = value; }
            }
            
            
        }
    }
}
