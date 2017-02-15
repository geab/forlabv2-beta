using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LQT.GUI.UserCtr
{
    public partial class LqtToolStrip : UserControl
    {
        public event EventHandler SaveAndCloseClick;
        public event EventHandler SaveAndNewClick;

        public LqtToolStrip()
        {
            InitializeComponent();
        }

        private void tsbSaveandclose_Click(object sender, EventArgs e)
        {
            if (SaveAndCloseClick != null)
            {
                SaveAndCloseClick(sender, e);
            }
        }

        private void tsbSaveandnew_Click(object sender, EventArgs e)
        {
            if (SaveAndNewClick != null)
            {
                SaveAndNewClick(sender, e);
            }
        }

        public void EnableSaveButton()
        {
            this.tsbSaveandclose.Enabled = true;
            this.tsbSaveandnew.Enabled = true;
        }

        public void DisableSaveButton()
        {
            this.tsbSaveandclose.Enabled = false;
            this.tsbSaveandnew.Enabled = false;
        }

        public void DisableSaveAndNewButton()
        {
            this.tsbSaveandnew.Enabled = false;
        }
    }
}
