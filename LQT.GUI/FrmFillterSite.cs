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

namespace LQT.GUI
{
    public partial class FrmFillterSite : Form
    {
        public ForlabSite _selectedSite;
        public FrmFillterSite()
        {
            InitializeComponent();
            PopRegion();
            PopSite();
        }

        private void PopRegion()
        {
            ForlabRegion r = new ForlabRegion();
            r.RegionName = "--All--";
            r.Id = 0;
           IList<ForlabRegion> regionList=DataRepository.GetAllRegion();
           regionList.Insert(0, r);

           comRegion.DataSource = regionList;
          
        }

        private void PopSite()
        {

            if (comRegion.Text != "--All--")
            {
                comSite.DataSource = DataRepository.GetAllSiteByRegionId((int)comRegion.SelectedValue);
            }
            else
                comSite.DataSource = DataRepository.GetAllSite();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _selectedSite = DataRepository.GetSiteById((int)comSite.SelectedValue);
            this.Tag = _selectedSite.SiteName;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
          // LQT.GUI.UserCtr.SitePane sp= (LQT.GUI.UserCtr.SitePane)this.Parent;
         
            Close();
        }

       

        private void comRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopSite();
        }
    }
}
