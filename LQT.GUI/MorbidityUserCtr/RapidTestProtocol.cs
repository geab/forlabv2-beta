using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LQT.Core.Util;
using LQT.Core.Domain;
using LQT.GUI.Testing;

namespace LQT.GUI.MorbidityUserCtr
{
    public partial class RapidTestProtocol : BaseMorbidityControl
    {
        private MorbidityForecast _forecast;
        private IList<RapidTestSpec> _scrtest;
        private IList<RapidTestSpec> _contest;
        private IList<RapidTestSpec> _tietest;
        private bool _edited = false;
        private ForlabParameter _paramNegative;
        private ForlabParameter _paramPositive;
        private ForlabParameter _paramDiscordant;

        public RapidTestProtocol(MorbidityForecast forecast)
        {
            _forecast = forecast;
            this._products = DataRepository.GetAllProductByClassOfTest(ClassOfMorbidityTestEnum.RapidTest.ToString());
            this._qMenus = DataRepository.GetAllQuantifyMenuByClass(ClassOfMorbidityTestEnum.RapidTest.ToString());
            
            InitializeComponent();

            lsvSerial.AddNoneEditableColumn(0);
            lsvSerial.AddNoneEditableColumn(3);
            lsvSerial.AddNoneEditableColumn(4);
            lsvSerial.SubitemTextChanged +=new EventHandler<SubitemTextEventArgs>(lsvSerial_SubitemTextChanged);

            lsvParallel.AddNoneEditableColumn(0);
            lsvParallel.AddNoneEditableColumn(3);
            lsvParallel.AddNoneEditableColumn(4);
            lsvParallel.SubitemTextChanged += new EventHandler<SubitemTextEventArgs>(lsvParallel_SubitemTextChanged);

            PopProductToComboBox(comSrapid1, TestingSpecificationGroup.Screening);
            PopProductToComboBox(comSrapid2, TestingSpecificationGroup.Screening);
            PopProductToComboBox(comSrapid3, TestingSpecificationGroup.Screening);

            PopProductToComboBox(comSCrapid1, TestingSpecificationGroup.Confirmatory);
            PopProductToComboBox(comSCrapid2, TestingSpecificationGroup.Confirmatory);
            PopProductToComboBox(comSCrapid3, TestingSpecificationGroup.Confirmatory);

            PopProductToComboBox(comSTrapid1, TestingSpecificationGroup.Tie_Breaker);
            PopProductToComboBox(comSTrapid2, TestingSpecificationGroup.Tie_Breaker);
            PopProductToComboBox(comSTrapid3, TestingSpecificationGroup.Tie_Breaker);

            BindRapidTests();
            BindSerialRapidTest();
            BindParallelRapidTest();
            
            LoadSiteListView();
            PopTests();

            _paramNegative = DataRepository.GetForlabParameterByParamName("RulesBothNegative");
            _paramPositive = DataRepository.GetForlabParameterByParamName("RulesBothPositive");
            _paramDiscordant = DataRepository.GetForlabParameterByParamName("RulesDiscordant");

            comBothnegative.Text = _paramNegative.ParmValue;
            comBothpostive.Text = _paramPositive.ParmValue;
            comDiscordant.Text = _paramDiscordant.ParmValue;
        }

        public override string Title
        {
            get { return "Rapid Test Specifications"; }
        }

        public override MorbidityCtrEnum PriviousCtr
        {
            get
            {
                return MorbidityCtrEnum.PediatricPatientBehavior;
            }
        }

        public override MorbidityCtrEnum NextCtr
        {
            get
            {
                return _forecast.TypeofAlgorithmEnum == AlgorithmType.Parallel ? MorbidityCtrEnum.RapidTestParallel : MorbidityCtrEnum.RapidTestSerial;
            }
        }

        public override bool EnableNextButton()
        {
            return true;
        }

        public override string Description
        {
            get
            {
                //string desc = "";
                return "";
            }
        }

        public override bool DoSomthingBeforeUnload()
        {
            if (_edited)
            {
                SaveRapidTests();
            }
            return true;
        }

        private void lsvSerial_SubitemTextChanged(object sender, SubitemTextEventArgs e)
        {
            ListViewItem li = e.ListVItem;

            RapidTestSpec rt = (RapidTestSpec)li.Tag;
            switch (e.ColumnIndex)
            {
                case 1:
                    rt.SerialTestSensitivity = double.Parse(li.SubItems[1].Text);
                    li.SubItems[3].Text = rt.SerialFalseNegative.ToString();
                    break;
                case 2:
                    rt.SerialTestSpecificity = double.Parse(li.SubItems[2].Text);
                    li.SubItems[4].Text = rt.SerialFalsePositive.ToString();
                    break;
            }
            _edited = true;
        }

        private void lsvParallel_SubitemTextChanged(object sender, SubitemTextEventArgs e)
        {
            ListViewItem li = e.ListVItem;

            RapidTestSpec rt = (RapidTestSpec)li.Tag;
            switch (e.ColumnIndex)
            {
                case 1:
                    rt.ParallelTestSensitivity = double.Parse(li.SubItems[1].Text);
                    li.SubItems[3].Text = rt.ParallelFalseNegative.ToString();
                    break;
                case 2:
                    rt.ParallelTestSpecificity = double.Parse(li.SubItems[2].Text);
                    li.SubItems[4].Text = rt.ParallelFalsePositive.ToString();
                    break;
            }
            _edited = true;
        }

        private void BindRapidTests()
        {
            _scrtest = DataRepository.GetRapidTestSpecByTestGroup(TestingSpecificationGroup.Screening.ToString());

            if (_scrtest.Count == 0)
            {
                for (int i = 1; i <= 3; i++)
                {
                    RapidTestSpec r = new RapidTestSpec();
                    r.ProductOrder = i;
                    r.TestGroup = TestingSpecificationGroup.Screening.ToString();
                    _scrtest.Add(r);
                }
            }
            else
            {
                foreach (RapidTestSpec r in _scrtest)
                {
                    if (r.ProductOrder == 1 && r.Product != null)
                    {
                        comSrapid1.Text = r.Product.ProductName;
                    }
                    else if (r.ProductOrder == 2 && r.Product != null)
                    {
                        comSrapid2.Text = r.Product.ProductName;
                    }
                    else if (r.ProductOrder == 3 && r.Product != null)
                    {
                        comSrapid3.Text = r.Product.ProductName;
                    }
                }
            }
            _contest = DataRepository.GetRapidTestSpecByTestGroup(TestingSpecificationGroup.Confirmatory.ToString());

            if (_contest.Count == 0)
            {
                for (int i = 1; i <= 3; i++)
                {
                    RapidTestSpec r = new RapidTestSpec();
                    r.ProductOrder = i;
                    r.TestGroup = TestingSpecificationGroup.Confirmatory.ToString();
                    _contest.Add(r);
                }
            }
            else
            {
                foreach (RapidTestSpec r in _contest)
                {
                    if (r.ProductOrder == 1 && r.Product != null)
                    {
                        comSCrapid1.Text = r.Product.ProductName;
                    }
                    if (r.ProductOrder == 2 && r.Product != null)
                    {
                        comSCrapid2.Text = r.Product.ProductName;
                    }
                    if (r.ProductOrder == 3 && r.Product != null)
                    {
                        comSCrapid3.Text = r.Product.ProductName;
                    }
                }
            }

            _tietest = DataRepository.GetRapidTestSpecByTestGroup(TestingSpecificationGroup.Tie_Breaker.ToString());
            if (_tietest.Count == 0)
            {
                for (int i = 1; i <= 3; i++)
                {
                    RapidTestSpec r = new RapidTestSpec();
                    r.ProductOrder = i;
                    r.TestGroup = TestingSpecificationGroup.Tie_Breaker.ToString();
                    _tietest.Add(r);
                }
            }
            else
            {
                foreach (RapidTestSpec r in _tietest)
                {
                    if (r.ProductOrder == 1 && r.Product != null)
                    {
                        comSTrapid1.Text = r.Product.ProductName;
                    }
                    else if (r.ProductOrder == 2 && r.Product != null)
                    {
                        comSTrapid2.Text = r.Product.ProductName;
                    }
                    else if (r.ProductOrder == 3 && r.Product != null)
                    {
                        comSTrapid3.Text = r.Product.ProductName;
                    }
                }
            }
        }

        private void PopProductToComboBox(ComboBox com, TestingSpecificationGroup testgroup)
        {
            IList<MasterProduct> list = DataRepository.GetAllProductByClassOfTest(ClassOfMorbidityTestEnum.RapidTest.ToString(), testgroup.ToString());
            list.Insert(0, new MasterProduct() { ProductName = "---NONE---" });

            com.DisplayMember = "ProductName";
            com.ValueMember = "Id";
            com.DataSource = list;
           com.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region screeining--------------------------------
            if (comSrapid1.Text != "---NONE---")
            {
                _scrtest[0].Product = LqtUtil.GetComboBoxValue<MasterProduct>(comSrapid1);                
            }
            else
            {
                _scrtest[0].Product = null;
            }

            if (comSrapid2.Text != "---NONE---")
            {
                _scrtest[1].Product = LqtUtil.GetComboBoxValue<MasterProduct>(comSrapid2);
            }
            else
            {
                _scrtest[1].Product = null;
            }

            if (comSrapid3.Text != "---NONE---")
            {
                _scrtest[2].Product = LqtUtil.GetComboBoxValue<MasterProduct>(comSrapid3);
            }
            else
            {
                _scrtest[2].Product = null;
            }
            
            #endregion

            #region Confermatory------------------------
            if (comSCrapid1.Text != "---NONE---")
            {
                _contest[0].Product = LqtUtil.GetComboBoxValue<MasterProduct>(comSCrapid1);
            }
            else
            {
                _contest[0].Product = null;
            }

            if (comSCrapid2.Text != "---NONE---")
            {
                _contest[1].Product = LqtUtil.GetComboBoxValue<MasterProduct>(comSCrapid2);
            }
            else
            {
                _contest[1].Product = null;
            }

            if (comSCrapid3.Text != "---NONE---")
            {
                _contest[2].Product = LqtUtil.GetComboBoxValue<MasterProduct>(comSCrapid3);
            }
            else
            {
                _contest[2].Product = null;
            }
            #endregion

            #region tie-breaker--------------------------------
            if (comSTrapid1.Text != "---NONE---")
            {
                _tietest[0].Product = LqtUtil.GetComboBoxValue<MasterProduct>(comSTrapid1);
            }
            else
            {
                _tietest[0].Product = null;
            }

            if (comSTrapid2.Text != "---NONE---")
            {
                _tietest[1].Product = LqtUtil.GetComboBoxValue<MasterProduct>(comSTrapid2);
            }
            else
            {
                _tietest[1].Product = null;
            }

            if (comSTrapid3.Text != "---NONE---")
            {
                _tietest[2].Product = LqtUtil.GetComboBoxValue<MasterProduct>(comSTrapid3);
            }
            else
            {
                _tietest[2].Product = null;
            }

            #endregion

            SaveRapidTests();

            BindSerialRapidTest();
            BindParallelRapidTest();
        }

        private void BindSerialRapidTest()
        {
            lsvSerial.Items.Clear();
            lsvSerial.BeginUpdate();
            ListViewGroup group = new ListViewGroup("Screening");
            lsvSerial.Groups.Add(group);
            for (int i = 0; i <= 2; i++)
            {
                string pname = _scrtest[i].Product != null ? _scrtest[i].Product.ProductName : "";
                ListViewItem li = new ListViewItem(pname) { Tag = _scrtest[i] };

                li.SubItems.Add(_scrtest[i].SerialTestSensitivity.ToString());
                li.SubItems.Add(_scrtest[i].SerialTestSpecificity.ToString());
                li.SubItems.Add(_scrtest[i].SerialFalseNegative.ToString());
                li.SubItems.Add(_scrtest[i].SerialFalsePositive.ToString());
                li.Group = group;
                lsvSerial.Items.Add(li);
            }

            group = new ListViewGroup("Confirmatory");
            lsvSerial.Groups.Add(group);
            for (int i = 0; i <= 2; i++)
            {
                string pname = _contest[i].Product != null ? _contest[i].Product.ProductName : "";
                ListViewItem li = new ListViewItem(pname) { Tag = _contest[i] };
                li.SubItems.Add(_contest[i].SerialTestSensitivity.ToString());
                li.SubItems.Add(_contest[i].SerialTestSpecificity.ToString());
                li.SubItems.Add(_contest[i].SerialFalseNegative.ToString());
                li.SubItems.Add(_contest[i].SerialFalsePositive.ToString());
                li.Group = group;
                lsvSerial.Items.Add(li);
            }


            group = new ListViewGroup("Tie-Breaker");
            lsvSerial.Groups.Add(group);
            for (int i = 0; i <= 2; i++)
            {
                string pname = _tietest[i].Product != null ? _tietest[i].Product.ProductName : "";
                ListViewItem li = new ListViewItem(pname) { Tag = _tietest[i] };
                li.SubItems.Add(_tietest[i].SerialTestSensitivity.ToString());
                li.SubItems.Add(_tietest[i].SerialTestSpecificity.ToString());
                li.SubItems.Add(_tietest[i].SerialFalseNegative.ToString());
                li.SubItems.Add(_tietest[i].SerialFalsePositive.ToString());
                li.Group = group;
                lsvSerial.Items.Add(li);
            }
            lsvSerial.EndUpdate();
        }

        private void BindParallelRapidTest()
        {
            lsvParallel.Items.Clear();
            lsvParallel.BeginUpdate();
            ListViewGroup group = new ListViewGroup("Screening");
            lsvParallel.Groups.Add(group);
            for (int i = 0; i <= 2; i++)
            {
                string pname = _scrtest[i].Product != null ? _scrtest[i].Product.ProductName : "";
                ListViewItem pli = new ListViewItem(pname) { Tag = _scrtest[i] };

                pli.SubItems.Add(_scrtest[i].ParallelTestSensitivity.ToString());
                pli.SubItems.Add(_scrtest[i].ParallelTestSpecificity.ToString());
                pli.SubItems.Add(_scrtest[i].ParallelFalseNegative.ToString());
                pli.SubItems.Add(_scrtest[i].ParallelFalsePositive.ToString());
                pli.Group = group;
                lsvParallel.Items.Add(pli);
            }

            group = new ListViewGroup("Confirmatory");
            lsvParallel.Groups.Add(group);
            for (int i = 0; i <= 2; i++)
            {
                string pname = _contest[i].Product != null ? _contest[i].Product.ProductName : "";
                ListViewItem pli = new ListViewItem(pname) { Tag = _contest[i] };

                pli.SubItems.Add(_contest[i].ParallelTestSensitivity.ToString());
                pli.SubItems.Add(_contest[i].ParallelTestSpecificity.ToString());
                pli.SubItems.Add(_contest[i].ParallelFalseNegative.ToString());
                pli.SubItems.Add(_contest[i].ParallelFalsePositive.ToString());
                pli.Group = group;
                lsvParallel.Items.Add(pli);
            }
            
            group = new ListViewGroup("Tie-Breaker");
            lsvParallel.Groups.Add(group);
            for (int i = 0; i <= 2; i++)
            {
                string pname = _tietest[i].Product != null ? _tietest[i].Product.ProductName : "";
                ListViewItem pli = new ListViewItem(pname) { Tag = _tietest[i] };

                pli.SubItems.Add(_tietest[i].ParallelTestSensitivity.ToString());
                pli.SubItems.Add(_tietest[i].ParallelTestSpecificity.ToString());
                pli.SubItems.Add(_tietest[i].ParallelFalseNegative.ToString());
                pli.SubItems.Add(_tietest[i].ParallelFalsePositive.ToString());
                pli.Group = group;
                lsvParallel.Items.Add(pli);
            }
            lsvParallel.EndUpdate();
        }
        
        private void SaveRapidTests()
        {
            for (int i = 0; i <= 2; i++)
            {
                DataRepository.SaveOrUpdateRapidTestSpec(_scrtest[i]);
                if (_scrtest[i].Product != null && DataRepository.GetQuantifyMenuByProductId(_scrtest[i].Product.Id) == null)
                {
                    QuantifyMenu qmenu = new QuantifyMenu();
                    qmenu.ClassOfTest = ClassOfMorbidityTestEnum.RapidTest.ToString();
                    qmenu.TestType = TestTypeEnum.Test.ToString();
                    qmenu.ProductId = _scrtest[i].Product.Id;
                    qmenu.Title = "Screening - " + _scrtest[i].Product.ProductName;
                    DataRepository.SaveOrUpdateQuantifyMenu(qmenu);
                }
                DataRepository.SaveOrUpdateRapidTestSpec(_contest[i]);
                if (_contest[i].Product != null &&  DataRepository.GetQuantifyMenuByProductId(_contest[i].Product.Id) == null)
                {
                    QuantifyMenu qmenu = new QuantifyMenu();
                    qmenu.ClassOfTest = ClassOfMorbidityTestEnum.RapidTest.ToString();
                    qmenu.TestType = TestTypeEnum.Test.ToString();
                    qmenu.ProductId = _contest[i].Product.Id;
                    qmenu.Title = "Confirmatory -  " + _contest[i].Product.ProductName;
                    DataRepository.SaveOrUpdateQuantifyMenu(qmenu);
                }
                DataRepository.SaveOrUpdateRapidTestSpec(_tietest[i]);
                if (_tietest[i].Product != null && DataRepository.GetQuantifyMenuByProductId(_tietest[i].Product.Id) == null)
                {
                    QuantifyMenu qmenu = new QuantifyMenu();
                    qmenu.ClassOfTest = ClassOfMorbidityTestEnum.RapidTest.ToString();
                    qmenu.TestType = TestTypeEnum.Test.ToString();
                    qmenu.ProductId = _tietest[i].Product.Id;
                    qmenu.Title = "Tie-Breaker - " + _tietest[i].Product.ProductName;
                    DataRepository.SaveOrUpdateQuantifyMenu(qmenu);
                }
            }
            _paramNegative.ParmValue =  comBothnegative.Text;
            _paramPositive.ParmValue = comBothpostive.Text;
            _paramDiscordant.ParmValue = comDiscordant.Text;

            DataRepository.SaveOrUpdateForlabParameter(_paramNegative);
            DataRepository.SaveOrUpdateForlabParameter(_paramPositive);
            DataRepository.SaveOrUpdateForlabParameter(_paramDiscordant);
            _edited = false;
        }

        #region product usage

        private IList<MasterProduct> _products;
        private IList<QuantifyMenu> _qMenus;
        private SiteListView _sListView;
        //private int _selectedTestId = 0;
        private void PopTests()
        {
            lbtRemove.Enabled = false;
            _sListView.BeginUpdate();
            _sListView.Items.Clear();

            foreach (QuantificationMetric qm in DataRepository.GetAllQuantificationMetricByClass(ClassOfMorbidityTestEnum.RapidTest.ToString()))
            {
                EXListViewItem li = new EXListViewItem(qm.Product.ProductName) { Tag = qm };

                li.SubItems.Add(new EXListViewSubItem(qm.Product.BasicUnit));
                li.SubItems.Add(new EXListViewSubItem(qm.UsageRate.ToString(), "U.Rate"));
                li.SubItems.Add(new EXListViewSubItem(qm.QuantifyMenu.Title));
                li.SubItems.Add(new EXListViewSubItem(qm.CollectionSupplieAppliedTo, "Supplies"));

                _sListView.Items.Add(li);
            }
            _sListView.EndUpdate();
        }
        private ComboBox _comSupplies;

        private void LoadSiteListView()
        {
            _sListView = new SiteListView();
            _sListView.MySortBrush = SystemBrushes.ControlLight;
            _sListView.MyHighlightBrush = Brushes.Goldenrod;
            _sListView.GridLines = true;
            _sListView.MultiSelect = false;
            _sListView.Dock = DockStyle.Fill;
            _sListView.ControlPadding = 4;
            _sListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            _comSupplies = new ComboBox();
            _comSupplies.Items.AddRange(Enum.GetNames(typeof(CollectionSupplieAppliedToEnum)));

            //add columns and items
            _sListView.Columns.Add(new EXColumnHeader("Product", 150));
            _sListView.Columns.Add(new EXColumnHeader("B.Unit", 60));
            EXEditableColumnHeader exEditCol = new EXEditableColumnHeader("U.Rate", 60);
            _sListView.Columns.Add(exEditCol);
            _sListView.Columns.Add(new EXColumnHeader("Quantify According to...", 100));

            exEditCol = new EXEditableColumnHeader("Supplies Apply to", _comSupplies, 100);
            _sListView.Columns.Add(exEditCol);

            _sListView.EditableListViewSubitemValueChanged += new EventHandler<EXEditableListViewSubitemEventArgs>(_sListView_EditableListViewSubitemValueChanged);
            _sListView.SelectedIndexChanged += new EventHandler(sListView_SelectedIndexChanged);
            panProduct.Controls.Add(_sListView);
        }

        private void _sListView_EditableListViewSubitemValueChanged(object sender, EXEditableListViewSubitemEventArgs e)
        {
            QuantificationMetric qm = (QuantificationMetric)e.ListVItem.Tag;

            if (e.SubItem.ColumnName.ToString() == "U.Rate")
            {
                try
                {
                    qm.UsageRate = Convert.ToDouble(e.SubItem.Text);
                }
                catch
                {
                    e.SubItem.Text = qm.UsageRate.ToString();
                }
            }
            else
            {
                qm.CollectionSupplieAppliedTo = e.SubItem.Text;
            }
            DataRepository.SaveOrUpdateQuantificationMetric(qm);
        }

        private void sListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbtRemove.Enabled = _sListView.SelectedItems.Count > 0;
        }

        private QuantificationMetric GetSelectedTest()
        {
            if (_sListView.SelectedItems.Count > 0)
                return (QuantificationMetric)_sListView.SelectedItems[0].Tag;
            return null;
        }

        private void lbtAddnew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSelectPro frm = new FrmSelectPro(_qMenus, _products);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PopTests();
            }
        }

        public bool DeleteSelectedItem()
        {
            if (GetSelectedTest() != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Selected Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        DataRepository.DeleteQuantificationMetric(GetSelectedTest());
                        MessageBox.Show("Selected Product was deleted successfully.", "Delete Selected Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    catch
                    {
                        MessageBox.Show("Error, unable to delete selected Product.", "Delete Selected Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            return false;
        }

        private void lbtRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DeleteSelectedItem())
                PopTests();
        }

        #endregion
    }
}
