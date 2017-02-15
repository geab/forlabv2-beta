using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using LQT.GUI.UserCtr;
using LQT.Core.Domain;
using LQT.Core.Util;
using LQT.Core.UserExceptions;

namespace LQT.GUI.Testing
{
    public partial class TestFrom : Form
    {
        private Test _test;
        private Form _mdiparent;
        private bool _isedited = false;

        public event EventHandler OnDataUsageEdit;
        public event EventHandler DisableSaveButton;
        public event EventHandler EnableSaveButton;
        private MasterConsumable _consum;

        public TestFrom(Test test, Form mdiparent)
        {
            this._test = test;
            this._mdiparent = mdiparent;            
            InitializeComponent();

            lqtToolStrip1.SaveAndCloseClick += new EventHandler(lqtToolStrip1_SaveAndCloseClick);
            lqtToolStrip1.SaveAndNewClick += new EventHandler(lqtToolStrip1_SaveAndNewClick);

            this.EnableSaveButton += new EventHandler(TestFrom_EnableSaveButton);
            this.DisableSaveButton += new EventHandler(TestFrom_DisableSaveButton);
            OnDataUsageEdit += new EventHandler(_taPane_OnDataUsageEdit);
            lsvProductUsage.AddNoneEditableColumn(0);
            lsvProductUsage.SubitemTextChanged += new EventHandler<SubitemTextEventArgs>(lsvProductUsage_OnSubitemTextChanged);

            lsvCProductUsage.AddNoneEditableColumn(0);
            lsvCProductUsage.SubitemTextChanged += new EventHandler<SubitemTextEventArgs>(lsvCProductUsage_OnSubitemTextChanged);

            lsvProductUsageT.AddNoneEditableColumn(0);
            lsvProductUsageT.AddNoneEditableColumn(1);
            lsvProductUsageP.AddNoneEditableColumn(0);
            lsvProductUsageP.AddNoneEditableColumn(1);
            lsvProductUsageI.AddNoneEditableColumn(0);
            lsvProductUsageI.AddNoneEditableColumn(1);
            lsvProductUsageT.SubitemTextChanged += new EventHandler<SubitemTextEventArgs>(lsvProductUsageT_SelectedIndexChanged);
            lsvProductUsageP.SubitemTextChanged += new EventHandler<SubitemTextEventArgs>(lsvProductUsageP_SelectedIndexChanged);
            lsvProductUsageI.SubitemTextChanged += new EventHandler<SubitemTextEventArgs>(lsvProductUsageI_SelectedIndexChanged);
            
            //
            PopTestingAreas();
           
            PopInstrument();
            PopProduct();

            PopCInstrument();
            PopCProduct();

           // PopMasterConsumable();
            PopConsInstrument();
            PopConsPeriod();
            PopConsProduct();
            
            LoadTestCtr();
        }
        
        private void PopMasterConsumable()
        {
            if (_test.Id > 0)
                _consum = DataRepository.GetConsumableByTestandArea(_test.Id, _test.TestingArea.Id);
            if(_consum==null)
                _consum = new MasterConsumable();
        }
        
        private void PopConsProduct()
        {
            comProductT.DataSource = DataRepository.GetAllProduct();
            comProductT.SelectedIndex = -1;

            comProductP.DataSource = DataRepository.GetAllProduct();
            comProductP.SelectedIndex = -1;

            comProductI.DataSource = DataRepository.GetAllProduct();
            comProductI.SelectedIndex = -1;

        }

        private void PopConsPeriod()
        {
            PeriodEnum[] period = LqtUtil.EnumToArray<PeriodEnum>();
            comPeriodP.DataSource = period;
            comPeriodP.SelectedIndex = -1;

            comPeriodI.DataSource = period;
            comPeriodI.SelectedIndex = -1;

        }

        private void PopConsInstrument()
        {
            TestingArea ta = LqtUtil.GetComboBoxValue<TestingArea>(comTestarea);

            if (ta != null)
            {
                comInstrumentI.DataSource = DataRepository.GetListOfInstrumentByTestingArea(ta.Id);
                if (comInstrumentI.Items.Count > 0)
                {
                    comInstrumentI.SelectedIndex = -1;
                    butAddI.Enabled = true;
                }
                else
                    butAddI.Enabled = false;
            }
            else
                butAddI.Enabled = false;
        }
        
        private void BindProductUsageT()
        {
            lsvProductUsageT.BeginUpdate();
            lsvProductUsageT.Items.Clear();

            int index = 0;
            foreach (ConsumableUsage r in _consum.ConsumableUsages)
            {
                if (r.PerTest == true)
                {
                    LQTListViewTag tag = new LQTListViewTag();
                    tag.GroupTitle = r.Product.ProductType.TypeName;
                    tag.Id = r.Id;
                    tag.Index = index;
                    ListViewItem li = new ListViewItem(r.Product.ProductName) { Tag = tag };
                    li.SubItems.Add(r.NoOfTest.ToString());
                    li.SubItems.Add(r.ProductUsageRate.ToString());

                    LqtUtil.AddItemToGroup(lsvProductUsageT, li);
                    lsvProductUsageT.Items.Add(li);
                    index++;
                }
            }

            lsvProductUsageT.EndUpdate();

        }

        private void BindProductUsageP()
        {
            lsvProductUsageP.BeginUpdate();
            lsvProductUsageP.Items.Clear();

            int index = 0;
            foreach (ConsumableUsage r in _consum.ConsumableUsages)
            {
                if (r.PerPeriod == true)
                {

                    LQTListViewTag tag = new LQTListViewTag();
                    tag.GroupTitle = r.Product.ProductType.TypeName;
                    tag.Id = r.Id;
                    tag.Index = index;
                    ListViewItem li = new ListViewItem(r.Product.ProductName) { Tag = tag };

                    li.SubItems.Add(r.Period.ToString());
                    li.SubItems.Add(r.ProductUsageRate.ToString());

                    LqtUtil.AddItemToGroup(lsvProductUsageP, li);
                    lsvProductUsageP.Items.Add(li);
                    index++;
                }
            }

            lsvProductUsageP.EndUpdate();

        }

        private void BindProductUsageI()
        {
            lsvProductUsageI.BeginUpdate();
            lsvProductUsageI.Items.Clear();

            int index = 0;
            foreach (ConsumableUsage r in _consum.ConsumableUsages)
            {
                if (r.PerInstrument == true)
                {
                    LQTListViewTag tag = new LQTListViewTag();
                    tag.GroupTitle = r.Instrument.InstrumentName;
                    tag.Id = r.Id;
                    tag.Index = index;
                    ListViewItem li = new ListViewItem(r.Product.ProductName) { Tag = tag };

                    li.SubItems.Add(r.Period.ToString());
                    li.SubItems.Add(r.ProductUsageRate.ToString());

                    LqtUtil.AddItemToGroup(lsvProductUsageI, li);
                    lsvProductUsageI.Items.Add(li);
                    index++;
                }
            }

            lsvProductUsageI.EndUpdate();

        }
        
        void lsvProductUsageT_OnSubitemTextChanged(object sender, SubitemTextEventArgs e)
        {
            LQTListViewTag tag = (LQTListViewTag)e.ListVItem.Tag;
            ListViewItem li = e.ListVItem;
            ConsumableUsage cu;// = (ProductUsage)li.Tag;

            if (tag.Id > 0)
                cu = _consum.GetConsumableUsage(tag.Id);
            else
                // cu = _consum.ConsumableUsages[tag.Index];
                cu = _consum.GetPerTestUsage()[tag.Index];

            try
            {
                decimal rate = decimal.Parse(li.SubItems[2].Text);
                cu.ProductUsageRate = rate;
            }
            catch
            {
                li.SubItems[1].Text = cu.ProductUsageRate.ToString();
            }

            if (OnDataUsageEdit != null)
            {
                OnDataUsageEdit(this, new EventArgs());
            }
        }

        void lsvProductUsageP_OnSubitemTextChanged(object sender, SubitemTextEventArgs e)
        {
            LQTListViewTag tag = (LQTListViewTag)e.ListVItem.Tag;
            ListViewItem li = e.ListVItem;
            ConsumableUsage cu;// = (ProductUsage)li.Tag;

            if (tag.Id > 0)
                cu = _consum.GetConsumableUsage(tag.Id);
            else
                cu = _consum.GetPerPeriodUsage()[tag.Index];


            try
            {
                decimal rate = decimal.Parse(li.SubItems[2].Text);
                cu.ProductUsageRate = rate;
            }
            catch
            {
                li.SubItems[1].Text = cu.ProductUsageRate.ToString();
            }

            if (OnDataUsageEdit != null)
            {
                OnDataUsageEdit(this, new EventArgs());
            }
        }

        void lsvProductUsageI_OnSubitemTextChanged(object sender, SubitemTextEventArgs e)
        {
            LQTListViewTag tag = (LQTListViewTag)e.ListVItem.Tag;
            ListViewItem li = e.ListVItem;
            ConsumableUsage cu;// = (ProductUsage)li.Tag;

            if (tag.Id > 0)
                cu = _consum.GetConsumableUsage(tag.Id);
            else
                // cu = _consum.ConsumableUsages[tag.Index];
                cu = _consum.GetPerInstrumentUsage()[tag.Index];


            try
            {
                decimal rate = decimal.Parse(li.SubItems[2].Text);
                cu.ProductUsageRate = rate;
            }
            catch
            {
                li.SubItems[1].Text = cu.ProductUsageRate.ToString();
            }

            if (OnDataUsageEdit != null)
            {
                OnDataUsageEdit(this, new EventArgs());
            }
        }      

        private void lsvProductUsageT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvProductUsageT.SelectedItems.Count > 0)
            {
                butRemoveT.Enabled = true;
            }
            else
                butRemoveT.Enabled = false;
        }
     

        private void butAddT_Click(object sender, EventArgs e)
        {
            
           // PopMasterConsumable();
            MasterProduct pro = LqtUtil.GetComboBoxValue<MasterProduct>(comProductT);
            if (pro != null)
            {
                if (!_consum.IsExsistUsageRatePerTest(pro.Id))
                {
                    if (txtNoofTest.Text != "0")
                    {
                        ConsumableUsage cu = new ConsumableUsage();
                        cu.NoOfTest = int.Parse(txtNoofTest.Text);
                        cu.PerTest = true;
                        cu.Product = pro;
                        cu.ProductUsageRate = 1;
                        cu.MasterConsumable = _consum;
                        _consum.ConsumableUsages.Add(cu);
                        BindProductUsageT();
                        if (OnDataUsageEdit != null)
                        {
                            OnDataUsageEdit(this, new EventArgs());
                        }
                    }
                }
            }
        }

        private void butAddP_Click(object sender, EventArgs e)
        {
           // PopMasterConsumable();
            MasterProduct pro = LqtUtil.GetComboBoxValue<MasterProduct>(comProductP);
            if (pro != null)
            {
                if (comPeriodP.SelectedValue != null)
                {

                    if (!_consum.IsExsistUsageRatePerPeriod(pro.Id))
                    {
                        ConsumableUsage cu = new ConsumableUsage();
                        cu.Period = comPeriodP.SelectedValue.ToString();
                        cu.PerPeriod = true;
                        cu.Product = pro;
                        cu.ProductUsageRate = 1;
                        cu.MasterConsumable = _consum;
                        _consum.ConsumableUsages.Add(cu);
                        BindProductUsageP();
                        if (OnDataUsageEdit != null)
                        {
                            OnDataUsageEdit(this, new EventArgs());
                        }
                    }
                }
            }

        }

        private void butAddI_Click(object sender, EventArgs e)
        {
           // PopMasterConsumable();
            Instrument ins = LqtUtil.GetComboBoxValue<Instrument>(comInstrumentI);
            if (ins != null)
            {

                MasterProduct pro = LqtUtil.GetComboBoxValue<MasterProduct>(comProductI);
                if (pro != null)
                {
                    //if (! _consum.IsExsistProductUsage(ins.Id, pro.Id))
                    // {
                    if (comPeriodI.SelectedValue != null)
                    {
                        if (!_consum.IsExsistUsageRatePerInst(ins.Id, pro.Id))
                        {

                            ConsumableUsage cu = new ConsumableUsage();
                            cu.Period = comPeriodI.Text;
                            cu.PerInstrument = true;
                            cu.Product = pro;
                            cu.Instrument = ins;
                            cu.ProductUsageRate = 1;
                            cu.MasterConsumable = _consum;
                            _consum.ConsumableUsages.Add(cu);
                            BindProductUsageI();
                            if (OnDataUsageEdit != null)
                            {
                                OnDataUsageEdit(this, new EventArgs());
                            }
                        }
                    }
                }
            }
        }

        private void lsvProductUsageP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvProductUsageP.SelectedItems.Count > 0)
            {
                butRemoveP.Enabled = true;
            }
            else
                butRemoveP.Enabled = false;
        }

        private void lsvProductUsageI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvProductUsageI.SelectedItems.Count > 0)
            {
                butRemoveI.Enabled = true;
            }
            else
                butRemoveI.Enabled = false;
        }

        private void butRemoveT_Click(object sender, EventArgs e)
        {

        }

        private void butRemoveP_Click(object sender, EventArgs e)
        {
            LQTListViewTag tag = (LQTListViewTag)lsvProductUsageP.SelectedItems[0].Tag;

            ConsumableUsage cu;
            if (lsvProductUsageP.SelectedItems.Count > 0)
            {
                if ((MessageBox.Show("Are you sure, do you want to remove it?", "Product Usage", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {


                    if (tag.Id > 0)
                        cu = _consum.GetConsumableUsage(tag.Id);
                    else
                        // cu = _consum.ConsumableUsages[tag.Index];
                        cu = _consum.GetPerPeriodUsage()[tag.Index];
                    _consum.ConsumableUsages.Remove(cu);

                    BindProductUsageP();
                    if (OnDataUsageEdit != null)
                    {
                        OnDataUsageEdit(this, new EventArgs());
                    }
                }
            }
        }

        private void butRemoveI_Click(object sender, EventArgs e)
        {
            LQTListViewTag tag = (LQTListViewTag)lsvProductUsageI.SelectedItems[0].Tag;

            ConsumableUsage cu;
            if (lsvProductUsageI.SelectedItems.Count > 0)
            {
                if ((MessageBox.Show("Are you sure, do you want to remove it?", "Product Usage", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {


                    if (tag.Id > 0)
                        cu = _consum.GetConsumableUsage(tag.Id);
                    else
                        // cu = _consum.ConsumableUsages[tag.Index];
                        cu = _consum.GetPerInstrumentUsage()[tag.Index];
                    _consum.ConsumableUsages.Remove(cu);

                    BindProductUsageI();
                    if (OnDataUsageEdit != null)
                    {
                        OnDataUsageEdit(this, new EventArgs());
                    }
                }
            }
        }

        //

        private void LoadTestCtr()
        {
            SetControlState();
            BindTest();
        }

        void _taPane_OnDataUsageEdit(object sender, EventArgs e)
        {
            _isedited = true;
        }

        void TestFrom_DisableSaveButton(object sender, EventArgs e)
        {
            lqtToolStrip1.DisableSaveButton();
        }

        void TestFrom_EnableSaveButton(object sender, EventArgs e)
        {
            lqtToolStrip1.EnableSaveButton();
        }

        void lqtToolStrip1_SaveAndNewClick(object sender, EventArgs e)
        {
            try
            {
                LQTUserMessage msg = SaveOrUpdateObject();
                ((LqtMainWindowForm)_mdiparent).ShowStatusBarInfo(msg.Message, true);

                TestingArea ta = _test.TestingArea;
                

                _test = new Test();
                _test.TestingArea = ta;
              

                // LoadTestCtr();
                SetControlState();
                SetConsControlState();
                comTestarea.Enabled = true;

                _isedited = false;
            }
            catch (Exception ex)
            {
                new FrmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
            }
        }

        private void SetConsControlState()
        {
            this.txtNoofTest.Text = "0";

            PopConsInstrument();
            PopConsProduct();
            PopConsPeriod();
            _consum = new MasterConsumable();
            BindProductUsageT();
            BindProductUsageP();
            BindProductUsageI();

        }

        void lqtToolStrip1_SaveAndCloseClick(object sender, EventArgs e)
        {
            try
            {
                LQTUserMessage msg = SaveOrUpdateObject();
                ((LqtMainWindowForm)_mdiparent).ShowStatusBarInfo(msg.Message, true);
                _isedited = false;

                this.Close();
            }
            catch (Exception ex)
            {
                new FrmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
            }
        }

        private void TestFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isedited)
            {
                System.Windows.Forms.DialogResult dr = MessageBox.Show("Do you want to save changes?", "Edit Site", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                try
                {
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        LQTUserMessage msg = SaveOrUpdateObject();
                        ((LqtMainWindowForm)_mdiparent).ShowStatusBarInfo(msg.Message, true);
                    }
                    else if (dr == System.Windows.Forms.DialogResult.Cancel)
                        e.Cancel = true;
                }
                catch (Exception ex)
                {
                    new FrmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
                    e.Cancel = true;
                }
            }
        }

        private void TestFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            NHibernateHelper.CloseSession();
        }

        private void SetControlState()
        {
            this.txtTestname.Text = "";
            PopTestingAreas();
            
            PopInstrument();
            PopProduct();

            BindProductUsage();
            BindCProductUsage();
        }

        private void PopTestingAreas()
        {
            comTestarea.DataSource = DataRepository.GetAllTestingArea();// DataRepository.GetTestingAreaByDemography(fa);

            if (comTestarea.Items.Count > 0)
                comTestarea.SelectedIndex = -1;
            else
            {
                DisableSaveButton(this, new EventArgs());
            }
        }

        

        private void PopInstrument()
        {
            TestingArea ta = LqtUtil.GetComboBoxValue<TestingArea>(comTestarea);

            if (ta != null)
            {
                comInstrument.DataSource = DataRepository.GetListOfInstrumentByTestingArea(ta.Id);
                if (comInstrument.Items.Count > 0)
                {
                    comInstrument.SelectedIndex = -1;
                    butAdd.Enabled = true;
                }
                else
                    butAdd.Enabled = false;
            }
            else
                butAdd.Enabled = false;
        }

        private void PopProduct()
        {
            comProduct.DataSource = DataRepository.GetAllProduct();
            comProduct.SelectedIndex = -1;

        }

        private void BindTest()
        {
            if (_test.TestingArea != null)
            {
                comTestarea.SelectedValue = _test.TestingArea.Id;
                comTestarea.Enabled = false;

            }

            if (_test.Id > 0)
            {
                this.txtTestname.Text = _test.TestName;
                //butAdd.Enabled = true;
            }
            BindProductUsage();
            BindCProductUsage();
            //BindProductUsageT();
            //BindProductUsageP();
            //BindProductUsageI();
        }

        public void RebindTest(Test test)
        {
            this._test = test;

            BindTest();

        }


        private void BindProductUsage()
        {
            lsvProductUsage.BeginUpdate();
            lsvProductUsage.Items.Clear();

            int index = 0;
            foreach (ProductUsage r in _test.GetProductUsageByType(false))
            {
                LQTListViewTag tag = new LQTListViewTag();
                tag.GroupTitle = r.Instrument.InstrumentName;
                tag.Id = r.Id;
                tag.Index = index;
                ListViewItem li = new ListViewItem(r.Product.ProductName) { Tag = tag };

                li.SubItems.Add(r.Rate.ToString());
                //li.SubItems.Add(r.ProductUsedIn);
                LqtUtil.AddItemToGroup(lsvProductUsage, li);
                lsvProductUsage.Items.Add(li);
                index++;
            }

            lsvProductUsage.EndUpdate();

        }

        public LQTUserMessage SaveOrUpdateObject()
        {
            if (txtTestname.Text == "")
                throw new LQTUserException("Test name must not be empty.");
            Test temp = DataRepository.GetTestByName(txtTestname.Text.Trim());
            if (_test.Id <= 0 && temp != null)
                throw new LQTUserException("The Test Name already exists.");
            if (temp != null && _test.Id != temp.Id)
                throw new LQTUserException("The Test Name already exists.");
            temp = null;

            this._test.TestName = this.txtTestname.Text.Trim();
           
            if (comTestarea.SelectedIndex < 0)
                throw new LQTUserException("Testing Area can not be empty.");


            if (_test.TestingArea == null )
            {
                _test.TestingArea = LqtUtil.GetComboBoxValue<TestingArea>(comTestarea);
               
            }

            DataRepository.SaveOrUpdateTest(_test);
            if (_consum!=null)
            {
                this._consum.Test = _test;
                this._consum.TestingArea = _test.TestingArea;
                if(_consum.ConsumableUsages.Count>0)
                DataRepository.SaveOrUpdateConsumables(_consum);
            }
            return new LQTUserMessage("Test was saved or updated successfully.");
        }

        void lsvProductUsage_OnSubitemTextChanged(object sender, SubitemTextEventArgs e)
        {
            LQTListViewTag tag = (LQTListViewTag)e.ListVItem.Tag;
            ListViewItem li = e.ListVItem;
            ProductUsage pu;// = (ProductUsage)li.Tag;

            if (tag.Id > 0)
                pu = _test.GetProductUsage(tag.Id);
            else
                pu = _test.GetProductUsageByType(false)[tag.Index];// ProductUsages[tag.Index];


            try
            {
                decimal rate = decimal.Parse(li.SubItems[1].Text);
                pu.Rate = rate;
            }
            catch
            {
                li.SubItems[1].Text = pu.Rate.ToString();
            }

            if (OnDataUsageEdit != null)
            {
                OnDataUsageEdit(this, new EventArgs());
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Instrument ins = LqtUtil.GetComboBoxValue<Instrument>(comInstrument);
            if (ins != null)
            {
                MasterProduct pro = LqtUtil.GetComboBoxValue<MasterProduct>(comProduct);
                if (pro != null)
                {
                    if (!_test.IsExsistProductUsage(ins.Id, pro.Id,false))
                    {
                        ProductUsage pu = new ProductUsage();
                        pu.Test = _test;
                        pu.Instrument = ins;
                        pu.Product = pro;
                        pu.Rate = 1;
                        pu.IsForControl = false;
                        _test.ProductUsages.Add(pu);

                        BindProductUsage();
                        if (OnDataUsageEdit != null)
                        {
                            OnDataUsageEdit(this, new EventArgs());
                        }
                    }
                }
            }
        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            LQTListViewTag tag = (LQTListViewTag)lsvProductUsage.SelectedItems[0].Tag;

            ProductUsage pu;
            if (lsvProductUsage.SelectedItems.Count > 0)
            {
                if ((MessageBox.Show("Are you sure, do you want to remove it?", "Test Product Usage", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {


                    if (tag.Id > 0)
                        pu = _test.GetProductUsage(tag.Id);
                    else
                        pu = _test.GetProductUsageByType(false)[tag.Index];// ProductUsages[tag.Index];
                    _test.ProductUsages.Remove(pu);

                    BindProductUsage();
                    if (OnDataUsageEdit != null)
                    {
                        OnDataUsageEdit(this, new EventArgs());
                    }
                }
            }
        }

        private void lsvProductUsage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvProductUsage.SelectedItems.Count > 0)
            {
                butRemove.Enabled = true;
            }
            else
                butRemove.Enabled = false;
        }

        private void comTestarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            PopInstrument();
            PopCInstrument();
                
                butAddT.Enabled = true;
                butAddP.Enabled = true;
                EnableSaveButton(this, new EventArgs());
           
            PopConsInstrument();
        
        }

        private void PopCInstrument()
        {
            lblCInstrumentControlP.Text = "";
            TestingArea ta = LqtUtil.GetComboBoxValue<TestingArea>(comTestarea);

            if (ta != null)
            {
                comCInstrument.DataSource = DataRepository.GetListOfInstrumentByTestingArea(ta.Id);
                if (comCInstrument.Items.Count > 0)
                {
                    comCInstrument.SelectedIndex = -1;
                    butCAdd.Enabled = true;
                }
                else
                    butCAdd.Enabled = false;
            }
            else
                butCAdd.Enabled = false;
        }

        private void PopCProduct()
        {
            comCProduct.DataSource = DataRepository.GetAllProduct();
            comCProduct.SelectedIndex = -1;

        }

        private void comCInstrument_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instrument _cIns = LqtUtil.GetComboBoxValue<Instrument>(comCInstrument);

            if (_cIns != null)
            {
                if (_cIns.DailyCtrlTest > 0)
                {
                    lblCInstrumentControlP.Text = InstrumentControlPeriod.Daily.ToString() + ":" + _cIns.DailyCtrlTest.ToString();
                }
                else if (_cIns.WeeklyCtrlTest > 0)
                {
                    lblCInstrumentControlP.Text = InstrumentControlPeriod.Weekly.ToString() + ":" + _cIns.WeeklyCtrlTest.ToString();
                }
                else if (_cIns.MonthlyCtrlTest > 0)
                {
                    lblCInstrumentControlP.Text = InstrumentControlPeriod.Monthly.ToString() + ":" + _cIns.MonthlyCtrlTest.ToString();
                }
                else if (_cIns.QuarterlyCtrlTest > 0)
                {
                    lblCInstrumentControlP.Text = InstrumentControlPeriod.Quarterly.ToString() + ":" + _cIns.QuarterlyCtrlTest.ToString();
                }
                else if (_cIns.MaxTestBeforeCtrlTest > 0)
                {
                    lblCInstrumentControlP.Text = InstrumentControlPeriod.Per_Test.ToString().Replace('_', ' ') + ":" + _cIns.MaxTestBeforeCtrlTest.ToString();
                }
                else
                    lblCInstrumentControlP.Text = "";
            }
            else
                lblCInstrumentControlP.Text = "";
        }

        private void butCAdd_Click(object sender, EventArgs e)
        {
            Instrument ins = LqtUtil.GetComboBoxValue<Instrument>(comCInstrument);
            if (ins != null)
            {
                MasterProduct pro = LqtUtil.GetComboBoxValue<MasterProduct>(comCProduct);
                if (pro != null)
                {
                    if (!_test.IsExsistProductUsage(ins.Id, pro.Id,true))
                    {
                        ProductUsage pu = new ProductUsage();
                        pu.Test = _test;
                        pu.Instrument = ins;
                        pu.Product = pro;
                        pu.Rate = 1;
                        pu.IsForControl = true;
                        _test.ProductUsages.Add(pu);

                        BindCProductUsage();
                        if (OnDataUsageEdit != null)
                        {
                            OnDataUsageEdit(this, new EventArgs());
                        }
                    }
                }
            }
        }

        private void BindCProductUsage()
        {
            lsvCProductUsage.BeginUpdate();
            lsvCProductUsage.Items.Clear();

            int index = 0;
            foreach (ProductUsage r in _test.GetProductUsageByType(true))
            {
                LQTListViewTag tag = new LQTListViewTag();
                tag.GroupTitle = r.Instrument.InstrumentName;
                tag.Id = r.Id;
                tag.Index = index;
                ListViewItem li = new ListViewItem(r.Product.ProductName) { Tag = tag };

                li.SubItems.Add(r.Rate.ToString());
                //li.SubItems.Add(r.ProductUsedIn);
                LqtUtil.AddItemToGroup(lsvCProductUsage, li);
                lsvCProductUsage.Items.Add(li);
                index++;
            }

            lsvCProductUsage.EndUpdate();

        }

        void lsvCProductUsage_OnSubitemTextChanged(object sender, SubitemTextEventArgs e)
        {
            LQTListViewTag tag = (LQTListViewTag)e.ListVItem.Tag;
            ListViewItem li = e.ListVItem;
            ProductUsage pu;// = (ProductUsage)li.Tag;

            if (tag.Id > 0)
                pu = _test.GetProductUsage(tag.Id);
            else
                pu = _test.GetProductUsageByType(true)[tag.Index];// ProductUsages[tag.Index];


            try
            {
                decimal rate = decimal.Parse(li.SubItems[1].Text);
                pu.Rate = rate;
            }
            catch
            {
                li.SubItems[1].Text = pu.Rate.ToString();
            }

            if (OnDataUsageEdit != null)
            {
                OnDataUsageEdit(this, new EventArgs());
            }
        }

        private void butCRemove_Click(object sender, EventArgs e)
        {
            LQTListViewTag tag = (LQTListViewTag)lsvCProductUsage.SelectedItems[0].Tag;

            ProductUsage pu;
            if (lsvCProductUsage.SelectedItems.Count > 0)
            {
                if ((MessageBox.Show("Are you sure, do you want to remove it?", "Test Control Product Usage", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {


                    if (tag.Id > 0)
                        pu = _test.GetProductUsage(tag.Id);
                    else
                        pu = _test.GetProductUsageByType(true)[tag.Index];// ProductUsages[tag.Index];
                    _test.ProductUsages.Remove(pu);

                    BindCProductUsage();
                    if (OnDataUsageEdit != null)
                    {
                        OnDataUsageEdit(this, new EventArgs());
                    }
                }
            }
        }

        private void lsvCProductUsage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCProductUsage.SelectedItems.Count > 0)
            {
                butCRemove.Enabled = true;
            }
            else
                butCRemove.Enabled = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                PopMasterConsumable();
                if(_consum!=null)
                {
                BindProductUsageT();
                BindProductUsageP();
                BindProductUsageI();
                }
            }
           
        }

        private void txtNoofTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = e.KeyChar;

            if ((x >= 48 && x <= 57) || (x == 8))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        
        }



    }
}
