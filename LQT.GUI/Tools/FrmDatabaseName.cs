using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LQT.GUI.Tools
{
    public partial class FrmDatabaseName : Form
    {
        private bool _badDatabaseName;
        private string _name;
        private bool _includeDefaultData;

        public string Result
        {
            get { return _name; }
        }

        public bool IncludeDefaultData
        {
            get { return _includeDefaultData; }
        }

        public FrmDatabaseName()
        {
            InitializeComponent();
        }

        private void textBoxDatabaseName_TextChanged(object sender, EventArgs e)
        {
            _badDatabaseName = false;
            textBoxDatabaseName.BackColor = Color.White;
            if (string.IsNullOrEmpty(textBoxDatabaseName.Text))
            {
                _badDatabaseName = true;
                textBoxDatabaseName.BackColor = Color.Red;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_badDatabaseName)
                MessageBox.Show("Error in database name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _name = textBoxDatabaseName.Text;
                _includeDefaultData = chkDefaultPData.Checked;
                Close();
            }
        }

        private void textBoxDatabaseName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
            }
        }
    }
}
