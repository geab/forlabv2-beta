using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LQT.Core.Domain;
using LQT.Core.Util;
using LQT.GUI.Consumables;
using LQT.Core.UserExceptions;

namespace LQT.GUI.UserCtr
{
    public partial class ListConsumablePane : BaseUserControl 
    {
        private int _selectedConsumableId = 0;
      

        public ListConsumablePane()
        {
            InitializeComponent();
            PopConsumables();
        }

        public override string GetControlTitle
        {
            get
            {
                return "Consumables";
            }
        }

        public override void ReloadUserCtrContents()
        {
            PopConsumables();
        }

        private void PopConsumables()
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();

            foreach (MasterConsumable c in DataRepository.GetAllConsumables())
            {
                ListViewItem li = new ListViewItem(c.TestingArea.AreaName) { Tag = c.Id };
                if(c.Test!=null)
                li.SubItems.Add(c.Test.TestName.ToString());
               
                if (c.Id == _selectedConsumableId)
                {
                    li.Selected = true;
                }
                listView1.Items.Add(li);
            }
            
            listView1.EndUpdate();

           
        }

        private MasterConsumable GetSelectedConsumable()
        {
            return DataRepository.GetSelectedConsumable(_selectedConsumableId);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            EditSelectedItem();
        }

        private void listView1_Resize(object sender, EventArgs e)
        {
           //// listView1.Columns[1].Width = listView1.Width - 5;
        }

        private void lbtAddnew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmConsumables frm = new FrmConsumables(new MasterConsumable(), MdiParentForm);
            frm.ShowDialog();
        }
      
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id = (int)listView1.SelectedItems[0].Tag;
                if (id != _selectedConsumableId)
                {
                    _selectedConsumableId = id;
                   
                }
            }
            SelectedItemChanged(listView1);
        }

        public override void EditSelectedItem()
        {
            FrmConsumables frm = new FrmConsumables(GetSelectedConsumable(), MdiParentForm);
            frm.ShowDialog();
        }

        public override bool DeleteSelectedItem()
        {
            if (MessageBox.Show("Are you sure you want to delete this Consumable?", "Delete Consumable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DataRepository.DeleteConsumable(GetSelectedConsumable());
                    MdiParentForm.ShowStatusBarInfo("Consumable was deleted successfully.");
                    DataRepository.CloseSession();
                    _selectedConsumableId = 0;
                    PopConsumables();
                    MdiParentForm.BuildNavigationMenu();
                    return true;
                }
                catch (Exception ex)
                {
                    DataRepository.CloseSession();
                    new FrmShowError(new ExceptionStatus() {ex=ex, message="Sorry, you could not delete this Consumable." }).ShowDialog();
                }
            }

            return false;
        }
    }
}
