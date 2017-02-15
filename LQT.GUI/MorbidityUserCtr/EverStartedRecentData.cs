﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using LQT.Core;
using LQT.Core.Util;
using LQT.Core.Domain;


namespace LQT.GUI.MorbidityUserCtr
{
    public partial class EverStartedRecentData : BaseMorbidityControl
    {
        private MorbidityForecast _forecast;
        private IList<ARTSite> _artSites;
        private bool _edited = false;
        private double? _sumofTimeZeroPatientOnTreatment;
        private double? _sumofTimeZeroPatientOnPreTreatment;

        public EverStartedRecentData(MorbidityForecast forecast, IList<ARTSite> artsite)
        {
            _forecast = forecast;
            _artSites = artsite;

            InitializeComponent();
            lqtListView1.AddNoneEditableColumn(0);
            lqtListView1.AddNoneEditableColumn(1);
            lqtListView1.SubitemTextChanged += new EventHandler<SubitemTextEventArgs>(lqtListView1_SubitemTextChanged);
            BindArtSites();
        }

        private void lqtListView1_SubitemTextChanged(object sender, SubitemTextEventArgs e)
        {
            ListViewItem li = e.ListVItem;

            ARTSite site = (ARTSite)li.Tag;
             int newvalue;
            if (e.ColumnIndex == 2)
            {
                if (int.TryParse(li.SubItems[2].Text, out newvalue))//b
                {
                    SetOnTreatmentAllocation(site, newvalue);
                }

            }
            else
            {
                if (int.TryParse(li.SubItems[3].Text, out newvalue))
                {
                    SetOnPreTreatmentAllocation(site, newvalue);
                }
            }


            _edited = true;
        }

        public override string Title
        {
            get { return "EVER STARTED Patient Numbers by Site"; }
        }
        public override MorbidityCtrEnum PriviousCtr
        {
            get
            {
                return MorbidityCtrEnum.OpEverStartedPatientTarget;
            }
        }
        public override MorbidityCtrEnum NextCtr
        {
            get
            {
                return MorbidityCtrEnum.OptArtPatientTarget;
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
                string des = "Enter Patient Data from the Last Month Prior to the Start of the Forecast </br>";
                des += "<p>Patients on Treatment and Pre-TreatmentIn the two columns of white cells, "
                + "enter the number of patients on treatment and on pre-treatment at each site for 'Time Zero.'</p>";
                return des;
            }
        }

        private void BindArtSites()
        {
            lqtListView1.Items.Clear();
            lqtListView1.BeginUpdate();

            foreach (ARTSite site in _artSites)
            {
                ListViewItem item = new ListViewItem(site.MorbidityCategory.CategoryName) { Tag = site };

                item.SubItems.Add(site.Site.SiteName);

                item.SubItems.Add(site.EverSTimeZeroPatientOnTreatment.ToString());
                item.SubItems.Add(site.EverSTimeZeroPatientOnPreTreatment.ToString());
                lqtListView1.Items.Add(item);
            }
            lqtListView1.EndUpdate();

        }

        public override bool DoSomthingBeforeUnload()
        {
            if (_edited)
            {
                DataRepository.BatchSaveARTSite(_artSites);
                DataRepository.SaveOrUpdateMorbidityForecast(_forecast);
            }
            return true;
        }

        private void PerformAddition()
        {
            _sumofTimeZeroPatientOnTreatment = 0;
            _sumofTimeZeroPatientOnPreTreatment = 0;
            foreach (ARTSite site in _artSites)
            {
                _sumofTimeZeroPatientOnTreatment += site.EverSTimeZeroPatientOnTreatment;
                _sumofTimeZeroPatientOnPreTreatment += site.EverSTimeZeroPatientOnPreTreatment;
            }
        }

        private double? SumOfTimeZeroPatientOnTreatment
        {
            get
            {
                if (!_sumofTimeZeroPatientOnTreatment.HasValue)
                {
                    PerformAddition();
                }
                return _sumofTimeZeroPatientOnTreatment;
            }
        }

        private double? SumOfTimeZeroPatientOnPreTreatment
        {
            get
            {
                if (!_sumofTimeZeroPatientOnPreTreatment.HasValue)
                {
                    PerformAddition();
                }
                return _sumofTimeZeroPatientOnPreTreatment;
            }
        }

        private void SetOnTreatmentAllocation(ARTSite site, int newvalue)
        {
            double total = SumOfTimeZeroPatientOnTreatment.Value;
            total = (total - site.EverSTimeZeroPatientOnTreatment) + newvalue;
            site.EverSTimeZeroPatientOnTreatment = newvalue;
            _sumofTimeZeroPatientOnTreatment = total;
            _forecast.EverSTimeZeroPatientOnTreatment = _sumofTimeZeroPatientOnTreatment.Value;
        }

        private void SetOnPreTreatmentAllocation(ARTSite site, int newvalue)
        {
            double total = SumOfTimeZeroPatientOnPreTreatment.Value;
            total = (total - site.EverSTimeZeroPatientOnPreTreatment) + newvalue;
            site.EverSTimeZeroPatientOnPreTreatment = newvalue;
            _sumofTimeZeroPatientOnPreTreatment = total;
            _forecast.EverSTimeZeroPatientOnPreTreatment = _sumofTimeZeroPatientOnPreTreatment.Value;
        }
    }
}
