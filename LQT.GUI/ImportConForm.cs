﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

using LQT.Core.Domain;
using LQT.Core.UserExceptions;
using LQT.Core.Util;
using LQT.GUI.UserCtr;


namespace LQT.GUI
{
    public partial class ImportConForm : Form
    {
        private ForecastInfo _forecastInfo;
        private IList<ReportedData> _rdata;
        private int _noColumn;

        public ForecastInfo GetForecastInfo
        {
            get { return _forecastInfo; }
        }

        public ImportConForm(ForecastInfo finfo)
        {
            this._forecastInfo = finfo;
            InitializeComponent();

            txtForecastid.Text = _forecastInfo.ForecastNo;
            txtPeriod.Text = _forecastInfo.Period;
            txtSdate.Text = _forecastInfo.StartDate.ToShortDateString();
            txtExtension.Text = _forecastInfo.Extension.ToString();
            txtMethodology.Text = _forecastInfo.Methodology;
            txtDusage.Text = _forecastInfo.DataUsage;

            if (_forecastInfo.DatausageEnum == DataUsageEnum.DATA_USAGE3)
            {
                lvImport.Columns.Remove(lvImport.Columns[2]);
                lvImport.Columns.Remove(lvImport.Columns[2]);

                _noColumn = 6;
            }
            else
            {
                lvImport.Columns.Remove(lvImport.Columns[1]);
                _noColumn = 7;
            }
        }

        private void butBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                txtFilename.Text = openFileDialog1.FileName;
            }
        }
               
        private IList<ReportedData> GetDataRow(DataSet ds)
        {
            string categoryName = null;
            string regionName;
            string siteName;
            string productName;
            string duration;
            decimal amount;
            int stockout;
            int instrumentDownTime;
            decimal adjusited;
            int rowno = 0;
            bool haserror;
            string cName = "";
            string rName = "";
            string sName = "";
            string pName = "";
            ForecastCategory fcategory = null;
            ForlabRegion region = null;
            ForlabSite site = null;
            MasterProduct product = null;
            //Test test = null;
            string errorDescription = "";
            IList<ReportedData> rdlist = new List<ReportedData>();
            DataRow dr = ds.Tables[0].Rows[0];
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{
            //try
            //{
                for (int i = 1; i < ds.Tables[0].Rows.Count; i = i + 4)
                {
                    rowno++;
                    haserror = false;
                    DataRow dr1 = ds.Tables[0].Rows[i];
                    DataRow dr2 = ds.Tables[0].Rows[i + 1];
                    DataRow dr3 = ds.Tables[0].Rows[i + 2];
                    DataRow dr4 = ds.Tables[0].Rows[i + 3];
                    DataRow g = ds.Tables[0].Rows[0];
                    int f = 3;
                    int colid;//0 
                    if (_forecastInfo.DatausageEnum == DataUsageEnum.DATA_USAGE3)
                        colid = 3;
                    else
                        colid = 4;
                    do
                    {
                        regionName = "";
                        siteName = "";

                        if (_forecastInfo.DatausageEnum == DataUsageEnum.DATA_USAGE3)
                        {
                            categoryName = Convert.ToString(dr1[0]).Trim();//(dr[colid++])
                            productName = Convert.ToString(dr1[1]).Trim();   //(dr[colid++])product name
                        }
                        else
                        {
                            regionName = Convert.ToString(dr1[0]).Trim(); //(dr[colid++]) region name
                            siteName = Convert.ToString(dr1[1]).Trim();           //(dr[colid++]) site name
                            productName = Convert.ToString(dr1[2]).Trim();   //(dr[colid++])product name
                        }
                        if (_forecastInfo.PeriodEnum != ForecastPeriodEnum.Monthly || _forecastInfo.PeriodEnum != ForecastPeriodEnum.Bimonthly)
                            duration = Convert.ToString(DateTime.FromOADate(Convert.ToDouble(dr[colid])));//(g[f]) Convert.ToString(dr[colid++]); //  reporting period(duration)
                        else
                            duration = Convert.ToString(dr[colid]);
                        try
                        {
                            amount = Convert.ToDecimal(dr1[colid]);  //amount
                            if(amount==0)
                                haserror = true;
                        }
                        catch
                        {
                            haserror = true;
                            amount = 0;
                        }
                        try
                        {
                            stockout = Convert.ToInt32(dr2[colid]);     //stock out
                        }
                        catch
                        {
                            haserror = true;
                            stockout = 0;
                        }
                        try
                        {
                            instrumentDownTime = Convert.ToInt32(dr3[colid]);     //instrumentDownTime
                        }
                        catch
                        {
                            haserror = true;
                            instrumentDownTime = 0;
                        }


                        adjusited = 0;
                        ReportedData rd = null;

                        if (_forecastInfo.DatausageEnum == DataUsageEnum.DATA_USAGE3)
                        {
                            rd = new ReportedData(rowno, categoryName, productName, duration, amount, stockout, instrumentDownTime);//b
                            if (cName != categoryName)
                            {
                                if (!string.IsNullOrEmpty(categoryName))
                                {
                                    fcategory = DataRepository.GetForecastCategoryByName(_forecastInfo.Id, categoryName);
                                }
                                else
                                    fcategory = null;
                                cName = categoryName;
                            }

                            if (fcategory != null)
                                rd.Category = fcategory;
                            else
                            {
                                rd.HasError = true;
                                errorDescription = errorDescription + " Category Doesn't Exist";
                            }

                        }
                        else
                        {
                            rd = new ReportedData(rowno, regionName, siteName, productName, duration, amount, stockout, instrumentDownTime);//b

                            if (rName != regionName)
                            {
                                if (!string.IsNullOrEmpty(regionName))
                                    region = DataRepository.GetRegionByName(regionName);
                                else
                                    region = null;
                                rName = regionName;
                            }

                            if (region != null)
                            {
                                rd.Region = region;
                                if (sName != siteName)
                                {
                                    if (!string.IsNullOrEmpty(siteName))
                                        site = DataRepository.GetSiteByName(siteName, region.Id);
                                    else
                                        site = null;
                                    sName = siteName;
                                }
                                if (site != null)
                                    rd.Site = site;
                                else
                                {
                                    haserror = true;
                                    errorDescription = errorDescription + " Site Doesn't Exist";
                                }
                            }
                            else
                            {
                                haserror = true;
                                errorDescription = errorDescription + " Region Doesn't Exist";
                            }
                        }

                        if (pName != productName)
                        {
                            if (!string.IsNullOrEmpty(productName))
                                product = DataRepository.GetProductByName(productName);
                            else
                                product = null;
                            pName = productName;
                        }

                        if (product != null)
                            rd.Product = product;
                        else
                        {
                            haserror = true;
                            errorDescription = errorDescription + " Product Doesn't Exist";
                        }

                        rd.HasError = haserror;
                        rd.ErrorDescription = errorDescription;
                        rdlist.Add(rd);
                        colid++;
                        errorDescription = "";
                    }
                    while (colid < g.ItemArray.Length && g[colid].ToString() != "");// dr.ItemArray.Length / ds.Tables[0].Rows.Count);
                }
            //}
            //catch (Exception ex)
            //{ }
            return rdlist;
        }

        private void butImport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilename.Text.Trim()))
                return;
            try
            {
                DataSet ds = LqtUtil.ReadExcelFileforecast(txtFilename.Text, _noColumn);
                
                _rdata = GetDataRow(ds);
                lvImport.BeginUpdate();
                lvImport.Items.Clear();
                ForecastSite fs = new ForecastSite();
                ForecastCategorySite fcatsite = new ForecastCategorySite();

                bool isduplicate = false;
                ForecastSite efs = new ForecastSite();//existing
                IList<ForecastSiteProduct> existingFsp = new List<ForecastSiteProduct>();
                foreach (ForecastSite efss in _forecastInfo.ForecastSites)
                {
                    foreach (ForecastSiteProduct efsp in efss.SiteProducts)
                        existingFsp.Add(efsp);
                }

                foreach (ReportedData rd in _rdata)
                {
                    ListViewItem li = new ListViewItem(rd.RowNo.ToString());

                    if (_forecastInfo.DatausageEnum == DataUsageEnum.DATA_USAGE3)
                    {
                        li.SubItems.Add(rd.CategoryName);
                    }
                    else
                    {
                        li.SubItems.Add(rd.RegionName);
                        li.SubItems.Add(rd.SiteName);
                    }

                    li.SubItems.Add(rd.ProductName);
                    if (!LqtUtil.IsDateTime(rd.Duration))
                    {
                        
                        try
                        {
                            DateTime dd = LqtUtil.DurationToDateTime(rd.Duration);
                            if (rd.Duration.StartsWith("Q") && (_forecastInfo.PeriodEnum == ForecastPeriodEnum.Yearly))
                            {

                                rd.Duration = dd.Year.ToString();
                                li.SubItems.Add(LqtUtil.DatetimeToDurationStr(_forecastInfo.PeriodEnum, dd));
                            }
                            else
                            li.SubItems.Add(rd.Duration);
                        }
                        catch (Exception ex)
                        {
                            li.SubItems.Add(rd.Duration);
                            rd.HasError = true;
                        }
                       
                    }
                    else
                    {
                       
                        string datestr = LqtUtil.DatetimeToDurationStr(_forecastInfo.PeriodEnum, DateTime.Parse(rd.Duration));
                        if (!rd.Duration.StartsWith("Q"))
                        {
                            rd.Duration = LqtUtil.DatetimeToDurationStr(_forecastInfo.PeriodEnum, DateTime.Parse(rd.Duration));
                            if (_forecastInfo.PeriodEnum == ForecastPeriodEnum.Yearly)
                            {
                                li.SubItems.Add(datestr);
                              
                            }
                            else
                            {
                                li.SubItems.Add(rd.Duration);
                                
                            }
                        }
                        else
                        {
                            {
                                li.SubItems.Add(datestr);
                               
                            }
                            

                        }

                    }
                    li.SubItems.Add(rd.Amount.ToString());
                    li.SubItems.Add(rd.StockOut.ToString());
                    li.SubItems.Add(rd.InstrumentDownTime.ToString());//
                    if (rd.HasError == true && rd.ErrorDescription == "")
                        rd.ErrorDescription = " Product Consumed Required ";
                    
                    li.SubItems.Add(rd.ErrorDescription.ToString());
                    if (LqtUtil.validDate(rd.Duration, _forecastInfo.PeriodEnum))
                        rd.HasError = true;

                   
                   


                    //add to forecast site product
                    if (!rd.HasError && _forecastInfo.DatausageEnum != DataUsageEnum.DATA_USAGE3)
                    {

                        ForecastSiteProduct fp = new ForecastSiteProduct();
                        fs = _forecastInfo.GetForecastSiteBySiteId(rd.Site.Id);

                        if (fs == null)
                        {
                            fs = new ForecastSite();
                            fs.Site = rd.Site;
                            fs.ForecastInfo = _forecastInfo;
                            _forecastInfo.ForecastSites.Add(fs);
                        }
                        fp.ForecastSite = fs;
                        fp.Product = rd.Product;
                        if (!LqtUtil.IsDateTime(rd.Duration))
                        {
                            fp.CDuration = rd.Duration;
                            fp.DurationDateTime = LqtUtil.DurationToDateTime(rd.Duration);
                            
                        }
                        else
                        { 
                            fp.DurationDateTime = DateTime.Parse(rd.Duration);
                            fp.CDuration = LqtUtil.DatetimeToDurationStr(_forecastInfo.PeriodEnum, DateTime.Parse(rd.Duration)); 
                        }
                        fp.AmountUsed = rd.Amount;
                        fp.StockOut = rd.StockOut;
                        fp.InstrumentDowntime = rd.InstrumentDownTime;//b
                        if (fp.StockOut > 0)
                        {
                            int days = fp.StockOut;
                            decimal workingday = GetActiveSiteWorkingDays(fp);

                            if (days >= workingday)
                            {
                                days = 0;
                                fp.StockOut = 0;
                            }
                            if (days >= 0)
                                fp.StockOut = days;
                        }

                        foreach (ForecastSiteProduct efsp in existingFsp)
                        {
                            isduplicate = false;
                            if (fp.ForecastSite.Site.Region == efsp.ForecastSite.Site.Region)
                                if (fp.ForecastSite.Site == efsp.ForecastSite.Site)
                                    if (fp.Product == efsp.Product && fp.DurationDateTime == efsp.DurationDateTime)
                                    { isduplicate = true; break; }
                        }
                        foreach (ForecastSiteProduct fsp in fs.SiteProducts)
                        {
                            isduplicate = false;
                            if (fp.ForecastSite.Site.Region == fsp.ForecastSite.Site.Region)
                                if (fp.ForecastSite.Site == fsp.ForecastSite.Site)
                                    if (fp.Product == fsp.Product && fp.DurationDateTime == fsp.DurationDateTime)
                                    { isduplicate = true; break; }
                        }
                        if (!isduplicate)
                            fs.SiteProducts.Add(fp);
                    }
                  
                    //end adding

                    //add by category
                    if (!rd.HasError && _forecastInfo.DatausageEnum == DataUsageEnum.DATA_USAGE3)
                    {
                            ForecastCategory fcat = new ForecastCategory();
                         ForecastCategoryProduct fp = new ForecastCategoryProduct();
                         fcat = _forecastInfo.GetForecastCategorybyname(rd.CategoryName);
                         if (fcat== null)
                         {
                             fcat = new ForecastCategory();
                             fcat.CategoryName = rd.CategoryName;
                             fcat.ForecastInfo = _forecastInfo;
                             _forecastInfo.ForecastCategories.Add(fcat);
                         }
                            

                        fp = fcat.GetFCatProduct(rd.Product.Id, rd.Duration);
                        isduplicate = false;

                        if (fp == null)
                            fp = new ForecastCategoryProduct();
                        else
                            isduplicate = true;

                        fp.Category = fcat;
                        fp.Product = rd.Product;
                        
                        fp.AmountUsed = rd.Amount;
                        fp.StockOut = rd.StockOut;
                        fp.InstrumentDowntime = rd.InstrumentDownTime;//b
                     
                        if (!LqtUtil.IsDateTime(rd.Duration))
                        {
                            fp.DurationDateTime = LqtUtil.DurationToDateTime(rd.Duration);
                            fp.CDuration = rd.Duration;
                        }
                        else
                        {
                            fp.DurationDateTime = DateTime.Parse(rd.Duration);
                            fp.CDuration = LqtUtil.DatetimeToDurationStr(_forecastInfo.PeriodEnum, DateTime.Parse(rd.Duration));
                        }

                        if (fp.StockOut > 0)
                        {
                            int days = fp.StockOut;
                            decimal workingday = 22;

                            if (days >= workingday)
                            {
                                days = 0;
                                fp.StockOut = 0;
                            }
                            if (days >= 0)
                                fp.StockOut = days;
                        }    
                        if (!isduplicate)
                            fcat.CategoryProducts.Add(fp);
                    }
                    //end category adding
                    if (rd.HasError)
                    {
                        li.BackColor = Color.Red;
                    }
                    else if (isduplicate)
                    {
                        li.BackColor = Color.Yellow;
                    }
                   
                   
                    lvImport.Items.Add(li);
                }

                lvImport.EndUpdate();

                butClear.Enabled = true;
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
            try
            {
                UpdateAdjustment();
                DataRepository.SaveOrUpdateForecastInfo(_forecastInfo);
                MessageBox.Show("Consumption data imported and saved successfully.", "Importing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error: Unable to import and save consumption data.", "Importing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAdjustment()
        {
            if (_forecastInfo.DatausageEnum == DataUsageEnum.DATA_USAGE1 || _forecastInfo.DatausageEnum == DataUsageEnum.DATA_USAGE2)
            {
                foreach (ForecastSite fs in _forecastInfo.ForecastSites)
                {
                    foreach (ForecastSiteProduct fp in fs.SiteProducts)
                    {
                        fp.Adjusted = fp.AmountUsed;
                        if (fp.AmountUsed == 0)
                        {
                            try
                            {
                                Consumption cs = GetConsumption(fp.Product.Id, fp);
                                fp.Adjusted = Math.Round(cs.TotalConsumption / cs.NoConsumption, 2, MidpointRounding.ToEven);
                            }
                            catch { fp.Adjusted = fp.AmountUsed; }
                        }
                        if ((fp.InstrumentDowntime > 0 || fp.StockOut > 0) && fp.AmountUsed > 0)
                            fp.Adjusted = LqtUtil.GetAdjustedVolume(fp.AmountUsed, fp.StockOut + fp.InstrumentDowntime, _forecastInfo.PeriodEnum, GetActiveSiteWorkingDays(fp));//b
                    }
                }
            }
            else
            {
                foreach (ForecastCategory fc in _forecastInfo.ForecastCategories)
                {
                    foreach (ForecastCategoryProduct fp in fc.CategoryProducts)
                    {
                        fp.Adjusted = fp.AmountUsed;
                        if (fp.AmountUsed == 0)
                        {
                            try
                            {
                                Consumption cs = GetConsumption(fp.Product.Id, fp);
                                fp.Adjusted = Math.Round(cs.TotalConsumption / cs.NoConsumption, 2, MidpointRounding.ToEven);
                            }
                            catch { fp.Adjusted = fp.AmountUsed; }
                        }
                        if ((fp.InstrumentDowntime > 0 || fp.StockOut > 0) && fp.AmountUsed > 0)
                            fp.Adjusted = LqtUtil.GetAdjustedVolume(fp.AmountUsed, fp.StockOut + fp.InstrumentDowntime, _forecastInfo.PeriodEnum, 22);//b
                    }
                }
            }
           
        }

        

        public Consumption GetConsumption(int id,ForecastSiteProduct fp)
        {
            Consumption con = null;
            switch (_forecastInfo.DatausageEnum)
                {
                    case DataUsageEnum.DATA_USAGE1:
                    case DataUsageEnum.DATA_USAGE2:
                        con = fp.ForecastSite.ConsumptionByProduct(id);
                        break;
                    case DataUsageEnum.DATA_USAGE3:
                        con = fp.ForecastSite.ConsumptionByProduct(id);
                        break;
                }
            return con;
        }
        public Consumption GetConsumption(int id, ForecastCategoryProduct fp)
        {
            Consumption con = null;
            switch (_forecastInfo.DatausageEnum)
            {
                case DataUsageEnum.DATA_USAGE1:
                case DataUsageEnum.DATA_USAGE2:
                    con = fp.Category.ConsumptionByProduct(id);
                    break;
                case DataUsageEnum.DATA_USAGE3:
                    con = fp.Category.ConsumptionByProduct(id);
                    break;
            }
            return con;
        }


        public decimal GetActiveSiteWorkingDays(ForecastSiteProduct fp)
        {
            decimal workingday = 22;

            switch (_forecastInfo.DatausageEnum)
            {
                case DataUsageEnum.DATA_USAGE1:
                case DataUsageEnum.DATA_USAGE2:
                    workingday = fp.ForecastSite.Site.WorkingDays;
                    break;
            }
            return workingday;
        }

       

        

    }

}
