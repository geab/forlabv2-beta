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
    public partial class FrmImportConsumable : Form
    {
        private IList<ImportProUsageData> _rdata;
        public FrmImportConsumable()
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
                DataSet ds = LqtUtil.ReadExcelFile(txtFilename.Text, 9);

                _rdata = GetDataRow(ds);
                bool haserror = false;

                lvImport.BeginUpdate();
                lvImport.Items.Clear();
                string errorString;

                foreach (ImportProUsageData rd in _rdata)
                {
                    string str;
                    errorString = "";
                    ListViewItem li = new ListViewItem(rd.RowNo.ToString());
                  
                    li.SubItems.Add(rd.TestName);
                    li.SubItems.Add(rd.InstrumentName);                    
                    li.SubItems.Add(rd.ProName);                    
                    li.SubItems.Add(rd.Period.ToString());
                    li.SubItems.Add(rd.NoOfTest.ToString());
                    li.SubItems.Add(rd.Rate.ToString());
                    li.SubItems.Add(rd.IsForTest.ToString());
                    li.SubItems.Add(rd.IsForPeriod.ToString());
                    li.SubItems.Add(rd.IsForInstrument.ToString());
                    str = rd.IsExist ? "Yes" : "No";

                    //foreach (ListViewItem Item in lvImport.Items)
                    //{
                    //    if (Item.SubItems[1].Text.Trim().ToLower() == rd.TestName.Trim().ToLower() && Item.SubItems[2].Text.Trim().ToLower() == rd.InstrumentName.Trim().ToLower().ToLower() && Item.SubItems[3].Text.Trim().ToLower() == rd.ProName.Trim().ToLower())
                    //    {
                    //        rd.IsExist = true;
                    //        str = "Duplicated";
                    //    }

                    //}

                    li.SubItems.Add(str);

                    if (rd.HasError)
                    {
                        if (rd.TestName == "")
                            errorString = errorString + " Test Name Required";
                        if (rd.InstrumentName == "")
                            errorString = errorString + " Instrument Name Required";
                        if (rd.ProName == "")
                            errorString = errorString + " Product Name Required";                      
                        if (rd.Cons == null)
                            errorString = errorString + " Test Doesn't Exist";
                        if (rd.Instrument == null)
                            errorString = errorString + " Instrument Doesn't Exist";
                        if (rd.Product == null)
                            errorString = errorString + " Product Doesn't Exist";
                       

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
                foreach (ImportProUsageData rd in _rdata)
                {
                    if (!rd.IsExist)
                    {


                        ConsumableUsage pu = new ConsumableUsage();
                      //  pu.Instrument = rd.Instrument;
                        pu.Product = rd.Product;
                        pu.ProductUsageRate = rd.Rate;
                        if (rd.IsForTest)
                        {
                            pu.NoOfTest = rd.NoOfTest;
                            pu.PerTest = rd.IsForTest;
                            rd.Cons.ConsumableUsages.Add(pu);
                            count++;
                        }
                        else if (rd.IsForPeriod)
                        {
                            pu.Period = rd.Period;
                            pu.PerPeriod = rd.IsForPeriod;
                            rd.Cons.ConsumableUsages.Add(pu);
                            count++;
                        }
                        else if (rd.IsForInstrument)
                        {
                            pu.Period = rd.Period;
                            pu.PerInstrument = rd.IsForInstrument;
                            pu.Instrument = rd.Instrument;
                            rd.Cons.ConsumableUsages.Add(pu);
                            count++;
                        
                        }
                        DataRepository.SaveOrUpdateConsumables(rd.Cons);
                    }
                    else { error++; }

                }

                MessageBox.Show(count + "Consumables are imported and saved successfully." + Environment.NewLine + error + " Consumables Failed.", "Importing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error: Unable to imported and saved Consumables data.", "Importing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DataRepository.CloseSession();
            }
        }

        private IList<ImportProUsageData> GetDataRow(DataSet ds)
        {
           
            string testName;
            string insName;
            string proName;
            string period;
            int noOfTest;
            decimal rate;
            string tName = "";
            string iName = "";
            bool isForTest = false;
            bool isForPeriod = false;
            bool isForInstrument = false;
            MasterConsumable cons = null;
            Test test = null;
            Instrument instrument = null;
            bool isnew = false;

            int rowno = 0;
            bool haserror;

            IList<ImportProUsageData> rdlist = new List<ImportProUsageData>();            
            List<string> con = new List<string>();
            

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rowno++;
                haserror = false;

                testName = Convert.ToString(dr[0]).Trim();   //region name
                insName = Convert.ToString(dr[1]).Trim();
                proName = Convert.ToString(dr[2]).Trim();
                period = Convert.ToString(dr[3]).Trim();
                try
                {
                    noOfTest = int.Parse(Convert.ToString(dr[4]));
                }
                catch
                {
                    noOfTest = 0;
                }
                try
                {
                rate = decimal.Parse( Convert.ToString(dr[5]));
                }
                catch
                {
                    rate =1;
                }
                try { isForTest = Convert.ToBoolean(int.Parse(Convert.ToString(dr[6]))); }
                catch { isForTest = false; }
                try { isForPeriod = Convert.ToBoolean(int.Parse(Convert.ToString(dr[7]))); }
                catch { isForPeriod = false; }
                try { isForInstrument = Convert.ToBoolean(int.Parse(Convert.ToString(dr[8]))); }
                catch { isForInstrument = false; }
               
                ImportProUsageData rd = new ImportProUsageData(testName,insName,proName,period ,noOfTest, rate,isForTest,isForPeriod,isForInstrument,rowno);

                if (!string.IsNullOrEmpty(Convert.ToString(dr[0])))
                    SaveConsumable(Convert.ToString(dr[0]));


                if (tName != testName)
                {
                    if (!string.IsNullOrEmpty(testName))
                        test = DataRepository.GetTestByName(testName);
                    else
                        test = null;
                    tName = testName;
                }

                if (test != null)
                {
                   // rd.Test = test;
                    cons = DataRepository.GetConsumableByName(testName);
                   
                     rd.Cons = cons;
                    if (iName != insName)
                    {
                        if (!String.IsNullOrEmpty(insName))
                            instrument = DataRepository.GetInstrumentByName(insName);
                        else
                            instrument = null;
                        iName = insName;
                    }

                    if (instrument != null)
                    {
                        rd.Instrument = instrument;

                        if (!String.IsNullOrEmpty(proName)&&!String.IsNullOrEmpty(rd.Period))
                        {
                            rd.Product = DataRepository.GetProductByName(proName);
                            if (rd.Product == null)
                                haserror = true;
                                if(!isnew)
                            if (cons.IsExsistUsageRatePerInst(instrument.Id, rd.Product.Id)&& rd.IsForInstrument==true)
                            {
                                rd.IsExist = true;
                            }
                        }
                        else
                            haserror = true;
                    }
                   // else
                       // haserror = true;
                    if (rd.IsForPeriod == true)
                    {
                        if (!String.IsNullOrEmpty(proName) && !String.IsNullOrEmpty(rd.Period))
                        {
                            rd.Product = DataRepository.GetProductByName(proName);
                            if (rd.Product == null)
                                haserror = true;
                                if(!isnew)
                            if (cons.IsExsistUsageRatePerPeriod(rd.Product.Id))
                            {
                                rd.IsExist = true;
                            }
                        }
                        else
                            haserror = true;
                    }
                     if (rd.IsForTest == true)
                    {
                        if (!String.IsNullOrEmpty(proName) && rd.NoOfTest>0)
                        {
                            rd.Product = DataRepository.GetProductByName(proName);
                            if (rd.Product == null)
                                haserror = true;
                                if(!isnew)
                            if (cons.IsExsistUsageRatePerPeriod(rd.Product.Id))
                            {
                                rd.IsExist = true;
                            }
                        }
                        else
                            haserror = true;
                    }

                }
                else
                    haserror = true;
                                
                                
                rd.HasError = haserror;
                rdlist.Add(rd);
                isnew = false;
            }

            return rdlist;
        }


        private class ImportProUsageData
        {
          
            private string _testname;
            private string _insName;
            private string _proname;
            private string _period;
            private decimal _rate;
            private int _rowno;
            private MasterConsumable _cons;
            private Instrument _instrument;
            private MasterProduct _product;
          
            private bool _haserror = false;
            private bool _isexist = false;
            bool _isForTest = false;
            bool _isForPeriod = false;
            bool _isForInstrument = false;
            int _noOfTest;

            public ImportProUsageData(string tname,string iname, string pname,string period,int noOfTest, decimal rate, bool isForTest,bool isForPeriod,bool isForInstrument,int rowno)
            {
               
                _testname = tname;
                _insName = iname;
                _proname = pname;
                _period = period;
                _noOfTest = noOfTest;
                _rate = rate;
                _isForTest = isForTest;
                _isForPeriod = isForPeriod;
                _isForInstrument=isForInstrument;
                _rowno = rowno;
            }

           
            public string TestName
            {
                get { return _testname; }
            }
            public string InstrumentName
            {
                get { return _insName; }
            }
            public string ProName
            {
                get { return _proname; }
            }
            public string Period
            {
                get { return _period; }
            }

            public int NoOfTest
            {
                get { return _noOfTest; }
            }

            public decimal Rate
            {
                get { return _rate; }
            }
            public int RowNo
            {
                get { return _rowno; }
            }

            public MasterConsumable Cons
            {
                get { return _cons; }
                set { _cons = value; }
            }
            public Instrument Instrument
            {
                get { return _instrument; }
                set { _instrument = value; }
            }
            public MasterProduct Product
            {
                get { return _product; }
                set { _product = value; }
            }

            public bool IsForTest
            {
                get { return _isForTest; }
            }

            public bool IsForPeriod
            {
                get { return _isForPeriod; }
            }

            public bool IsForInstrument
            {
                get { return _isForInstrument; }
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
        }

        IDictionary<string, MasterConsumable> _listOfImportedConsumable = new Dictionary<string, MasterConsumable>();
        private void SaveConsumable(string  impCons)
        {
            Test impTest = DataRepository.GetTestByName(impCons);
            if (!_listOfImportedConsumable.ContainsKey(impTest.TestName))
            {
                if (DataRepository.GetConsumableByName(impTest.TestName) == null)
                {
                    MasterConsumable con = new MasterConsumable();
                    con.Test = impTest;
                    con.TestingArea = impTest.TestingArea;
                    DataRepository.SaveOrUpdateConsumables(con);
                }
            }
        }

    }
}
