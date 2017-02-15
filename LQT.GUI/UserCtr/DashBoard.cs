using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace LQT.GUI.UserCtr
{
    public partial class DashBoard : LQT.GUI.UserCtr.BaseUserControl
    {
        private BaseUserControl _currentUserCtr;
        
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            BulildDashBoard();
        }

        private void BulildDashBoard()
        {
            this._currentUserCtr = new ChartSiteperRegion();

            LoadCurrentUserCtr();

            this._currentUserCtr = new ChartTestperArea();

            LoadCurrentUserCtr();

            this._currentUserCtr = new ProductNoperCat();

            LoadCurrentUserCtr();

            this._currentUserCtr = new chartSiteCategory();

            LoadCurrentUserCtr();

            this._currentUserCtr = new ChartSiteLevelperRegion();

            LoadCurrentUserCtr();

            this._currentUserCtr = new chartInstrumentDistribution();

            LoadCurrentUserCtr();
        }

        private void LoadCurrentUserCtr()
        {

           
            //_currentUserCtr.MdiParentForm = this;
           // _currentUserCtr.Dock = DockStyle.None;
            _currentUserCtr.Width = 404;
            _currentUserCtr.Height = 283;
            //_currentUserCtr.OnDoubleClick += new EventHandler(_currentUserCtr_OnDoubleClick);
            this.flowLayoutPanel.Controls.Add(_currentUserCtr);

        }
        private void _currentUserCtr_OnDoubleClick(object sender, EventArgs e)
        {
            if (sender is UserControl)
            {
                UserControl uc = (UserControl)sender;
               //this.flowLayoutPanel.Controls.Clear();

               // if (uc.Name == "ChartSiteperRegion")
               // {
               //     this._CurrCtr = new ChartSiteperRegion();
               // }
            
              
               // _CurrCtr.Dock = DockStyle.Fill;

               // this.flowLayoutPanel.Controls.Add(_CurrCtr);
            }

        }

    }
}
