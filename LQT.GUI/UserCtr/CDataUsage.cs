﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using LQT.Core.Domain;
using LQT.Core.UserExceptions;
using LQT.Core.Util;

namespace LQT.GUI.UserCtr
{
    public partial class CDataUsage : BaseHistoricalData//BaseUserControl
    {

        public CDataUsage(ForecastInfo finfo)
        {
            this._forecastInfo = finfo;
            InitializeComponent();
            base._lvHistData = lvProduct;
            base._chartSd = chart1;
            InitGridView();
            BindSites();
            BindForecastSite();
            ShowSummary();
        }

        private void BindSites()
        {
            lvSiteAll.BeginUpdate();
            lvSiteAll.Items.Clear();

                foreach (ForlabSite s in DataRepository.GetAllSite())
                {
                    if (!_forecastInfo.SiteIsSelected(s.Id))
                    {
                        ListViewItem li = new ListViewItem(s.SiteName) { Tag = s.Id };
                        lvSiteAll.Items.Add(li);
                    }
                }
                ShowSummary();//b
            lvSiteAll.EndUpdate();
    
        }

        private void BindForecastSite()
        {
            lvSite.BeginUpdate();
            lvSite.Items.Clear();

            foreach (ForecastSite s in _forecastInfo.ForecastSites)
            {
                ListViewItem li = new ListViewItem(s.Site.SiteName) { Tag = s.Id };
                lvSite.Items.Add(li);
            }

            lvSite.EndUpdate();
        }

        private void BindForecastSiteProduct()
        {
            lbtRemoveproduct.Enabled = false;
            lbtAddduration.Enabled = false;

            if (_activeFSite != null)
            {
                if (lvSite.SelectedItems.Count > 0)
                    base.BindForecastDataUsage(_activeFSite.Id, lvSite.SelectedItems[0].Index);
                lbtAddproduct.Enabled = true;
            }
            else
            {
                lbtAddproduct.Enabled = false;
            }
            ShowSummary();//b
        }

        private void lvSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSite.SelectedItems.Count <= 0)
            {
                lbtRemovesite.Enabled = false;
                lbtImport.Enabled = false;
                lbtAddduration.Enabled = false;
                lbtAddproduct.Enabled = false;
                _activeFSite = null;

                BindForecastSiteProduct();
                txtSitename.Text = "";
                txtPcount.Text = "";
            }
            else
            {
                int id = (int)lvSite.SelectedItems[0].Tag;

                if (id > 0)
                    _activeFSite = _forecastInfo.GetForecastSite(id);
                else
                    _activeFSite = _forecastInfo.ForecastSites[lvSite.SelectedItems[0].Index];

                BindForecastSiteProduct();

                lbtRemovesite.Enabled = true;
                lbtImport.Enabled = true;
                lbtAddproduct.Enabled = true;

                txtSitename.Text = _activeFSite.Site.SiteName;
                txtPcount.Text = _activeFSite.GetUniqFSProduct().Count.ToString();
                //txtConsumption.Text = _activeFSite.SiteProducts.Count.ToString();
            }
        }

        private void lbtAddsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int len = lvSiteAll.SelectedItems.Count;

            for (int i = 0; i < len; i++)
            {
                int siteid = (int)lvSiteAll.SelectedItems[i].Tag;
                ForecastSite fs = new ForecastSite();
                fs.Site = DataRepository.GetSiteById(siteid);
                fs.ForecastInfo = _forecastInfo;

                _forecastInfo.ForecastSites.Add(fs);
            }

            BindSites();
            BindForecastSite();

           
        }
        private void lbtAddsiteall_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < lvSiteAll.Items.Count; i++)
            {
                lvSiteAll.Items[i].Selected = true;
                lvSiteAll.Select();
            }
            int len = lvSiteAll.SelectedItems.Count;

            for (int i = 0; i < len; i++)
            {
                int siteid = (int)lvSiteAll.SelectedItems[i].Tag;
                ForecastSite fs = new ForecastSite();
                fs.Site = DataRepository.GetSiteById(siteid);
                fs.ForecastInfo = _forecastInfo;

                _forecastInfo.ForecastSites.Add(fs);
            }

            BindSites();
            BindForecastSite();
            lbtAddsiteall.Enabled = false;
            lbtAddsite.Enabled = false;


        }
        private void lbtRemovesite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvSite.SelectedItems.Count > 0)
            {
                int id = (int)lvSite.SelectedItems[0].Tag;
                ForecastSite fs = _forecastInfo.GetForecastSite(id);

                if (id > 0)
                    fs = _forecastInfo.GetForecastSite(id);
                else
                    fs = _forecastInfo.ForecastSites[lvSite.SelectedItems[0].Index];

                _forecastInfo.ForecastSites.Remove(fs);
                _activeFSite = null;
                DataRepository.DeleteForecastSite(fs);//b
                BindSites();
                BindForecastSite();
                BindForecastSiteProduct();
                txtSitename.Text = "";//b
                txtPcount.Text = "";//b
            }
        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (lvProduct.SelectedItems.Count <= 0)
            {
                lbtRemoveproduct.Enabled = false;
                lbtAddduration.Enabled = false;
            }
            else
            {
                lbtRemoveproduct.Enabled = true;
                lbtAddduration.Enabled = true; 
            }
        }

       
        private void lvSiteAll_Leave(object sender, EventArgs e)
        {
            lbtAddsite.Enabled = false;
        }

        private void lvSiteAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSiteAll.SelectedItems.Count <= 0)
                lbtAddsite.Enabled = false;
            else
                lbtAddsite.Enabled = true;
        }

        private void lbtAddproduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AddDatausage())//AddProdutOrTestDatausage())//nov 28
                BindForecastSiteProduct();
            txtSitename.Text = _activeFSite.Site.SiteName;//b
            txtPcount.Text = _activeFSite.GetUniqFSProduct().Count.ToString();//b
        }
     
        private void lbtRemoveproduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (RemoveDataUsageFromSite())
                BindForecastSiteProduct();

            txtSitename.Text = _activeFSite.Site.SiteName;//b
            txtPcount.Text = _activeFSite.GetUniqFSProduct().Count.ToString();//b
            
        }

        private void lbtAddduration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AddDurationDatausage())//AddDurationDatausage1())
                BindForecastSiteProduct();
        }

        private void lbtImport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            if (ImportConsumption())
            {
               
                BindSites();
                BindForecastSite();
                ShowSummary();
            }
        }

        private void ShowSummary()
        {
            txttotalsite.Text = _forecastInfo.ForecastSites.Count.ToString();
            txtTotalpcount.Text = DataRepository.FSTotalProductCount(_forecastInfo.Id).ToString();
        }

        private void lbtAddMultipro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          

            if (SelectSiteAndProduct())
            {
                BindSites();
                BindForecastSite();
                ShowSummary();

           
            }
        }

        protected override void OnStandardDivationChanged(StandardDivationEventArgs e)
        {
            //base.OnStandardDivationChanged(e);
            this.lblMean.Text = e.Mean;
            this.lblDeviation.Text = e.Deviation;
            this.lblMedian.Text = e.Median;

        }

        private void lvProduct_Leave(object sender, EventArgs e)
        {
            if (this._chartSd.Series.Count > 0)
            {
                this._chartSd.Series[0].Points.Clear();
                this._chartSd.Titles[0].Text = "";
                this.lblMean.Text = "";
                this.lblDeviation.Text = "";
                this.lblMedian.Text = "";
            }
        }
        

    }
}
