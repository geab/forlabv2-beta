using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using LQT.Core.DataAccess;
using LQT.Core.Domain;
using LQT.Core.Util;
using LQT.GUI.UserCtr;
using LQT.Core.UserExceptions;

namespace LQT.GUI.Testing
{
    public partial class TestingAreaFrom : Form
    {
        private TestingArea _testingArea;
        private Form _mdiparent;

        public TestingAreaFrom(TestingArea testingarea, Form mdiparent)
        {
            this._testingArea = testingarea;
            this._mdiparent = mdiparent;

            InitializeComponent();

            lqtToolStrip1.SaveAndCloseClick += new EventHandler(lqtToolStrip1_SaveAndCloseClick);
            lqtToolStrip1.SaveAndNewClick += new EventHandler(lqtToolStrip1_SaveAndNewClick);

            LoadTestingAreaCtr();
        }

        private void LoadTestingAreaCtr()
        {
            SetControlState();
            popCategory();
            BindTestingArea();
        }

        void lqtToolStrip1_SaveAndNewClick(object sender, EventArgs e)
        {
            try
            {
                LQTUserMessage msg = SaveOrUpdateObject();
                ((LqtMainWindowForm)_mdiparent).ShowStatusBarInfo(msg.Message);
                DataRepository.CloseSession();
                ((LqtMainWindowForm)_mdiparent).BuildNavigationMenu();
                _testingArea = new TestingArea();
                LoadTestingAreaCtr();
            }
            catch (Exception ex)
            {
                new FrmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
            }
        }

        void lqtToolStrip1_SaveAndCloseClick(object sender, EventArgs e)
        {
            try
            {
                LQTUserMessage msg = SaveOrUpdateObject();
                ((LqtMainWindowForm)_mdiparent).ShowStatusBarInfo(msg.Message, true);
                DataRepository.CloseSession();

                ((LqtMainWindowForm)_mdiparent).BuildNavigationMenu();
                this.Close();
            }
            catch (LQTUserException ex)
            {
                new FrmShowError(CustomExceptionHandler.ShowExceptionText(ex)).ShowDialog();
            }
            catch (Exception ex)
            {
                new FrmShowError(CustomExceptionHandler.ShowExceptionText("Error: unable to save or update testing area.", ex)).ShowDialog();
            }
        }

        private void SetControlState()
        {
            this.txtAreaname.Text = "";
            this.chkuseindemograph.Checked = false;
        }

        public void popCategory()
        {
            cobCategory.DataSource = LqtUtil.EnumToArray<ClassOfMorbidityTestEnum>();
            cobCategory.SelectedIndex = -1;
        }
        
        public LQTUserMessage SaveOrUpdateObject()
        {
            if (txtAreaname.Text.Trim() == "")
                throw new LQTUserException("Testing Area name must not be empty.");

            this._testingArea.AreaName = this.txtAreaname.Text.Trim();
            this._testingArea.UseInDemography = this.chkuseindemograph.Checked;
            if (this.chkuseindemograph.Checked)
            {
                this._testingArea.Category = this.cobCategory.SelectedValue.ToString();
            }
            else
            {
                this._testingArea.Category = null;
            }
            
            DataRepository.SaveOrUpdateTestingArea(_testingArea);

            return new LQTUserMessage("Testing Area was saved or updated successfully.");
        }

        private void BindTestingArea()
        {
            if (_testingArea.Id > 0)
            {
                this.txtAreaname.Text = _testingArea.AreaName;
                this.chkuseindemograph.Checked = _testingArea.UseInDemography;
              

                if (_testingArea.Category != null)
                    cobCategory.Text = _testingArea.Category;
                cobCategory.Enabled = _testingArea.UseInDemography;
            }
            
        }

        private void chkuseindemograph_CheckedChanged(object sender, EventArgs e)
        {
            cobCategory.Enabled = chkuseindemograph.Checked;
        }

        


    }
}
