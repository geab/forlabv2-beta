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
    public partial class OptArtPatientTarget : BaseMorbidityControl
    {
        private LQTCheckBox _activeCheckBox;
        private MorbidityForecast _forecast;
        private bool _edited = false;

        public OptArtPatientTarget(MorbidityForecast forecast)
        {
            this._forecast = forecast;
            InitializeComponent();

            if (forecast.OptArtPatinetTarget > 0)
            {
                switch (forecast.ArtPatinetTargetEnum)
                {
                    case OptArtPatinetTargetEnum.NationalTarget:
                        _activeCheckBox = chbNationaltarget;
                        break;
                    case OptArtPatinetTargetEnum.SiteGrowth:
                        _activeCheckBox = chbSitegrowth;
                        break;
                    case OptArtPatinetTargetEnum.SelectSite:
                        _activeCheckBox = chbSelectsite;
                        break;
                    case OptArtPatinetTargetEnum.AllSite:
                        _activeCheckBox = chbAllsite;
                        break;
                }
                _activeCheckBox.Checked = true;
            }
            else
            {
                OnNextButtonStatusChanged(false);
            }

            chbAllsite.LQTCheckBoxClick += new EventHandler<LQTCheckBoxEvenArgs>(LQTCheckBoxClick);
            chbNationaltarget.LQTCheckBoxClick += new EventHandler<LQTCheckBoxEvenArgs>(LQTCheckBoxClick);
            chbSelectsite.LQTCheckBoxClick += new EventHandler<LQTCheckBoxEvenArgs>(LQTCheckBoxClick);
            chbSitegrowth.LQTCheckBoxClick += new EventHandler<LQTCheckBoxEvenArgs>(LQTCheckBoxClick);
        }

        public override string Title
        {
            get { return "ART Patient Targets"; }
        }

        public override string Description
        {
            get
            {
                string desc ="Whether you chose to use the ON TREATMENT method or the ";
                desc +="EVER STARTED ON TREATMENT method, this screen will help you select your preferred method ";
                desc +="of setting ART patient targets for your country. The four options on this screen depend on ";
                desc +="how much data you have available. NOTE: If you chose the ON TREATMENT method, you should have ";
                desc += "skipped slides 29-32of this presentation.";
                return desc;
            }
        }

        public override MorbidityCtrEnum PriviousCtr
        {
            get
            {
                    return MorbidityCtrEnum.OptTreatmentTarget;
            }
        }

        public override MorbidityCtrEnum NextCtr
        {
            get
            {
                MorbidityCtrEnum ctrenum = MorbidityCtrEnum.Nothing;
                switch (_forecast.ArtPatinetTargetEnum)
                {
                    case OptArtPatinetTargetEnum.NationalTarget:
                    case OptArtPatinetTargetEnum.SiteGrowth:
                    case OptArtPatinetTargetEnum.SelectSite:
                        ctrenum  = MorbidityCtrEnum.SiteTargetCalculator;
                        break;
                    case OptArtPatinetTargetEnum.AllSite:
                        ctrenum = MorbidityCtrEnum.PatientNumbersSites;
                        break;
                }

                return ctrenum;
            }
        }

        public override bool EnableNextButton()
        {
            return _forecast.OptArtPatinetTarget > 0;
        }

        private void LQTCheckBoxClick(object sender, LQTCheckBoxEvenArgs e)
        {
            if (_activeCheckBox != null)
                _activeCheckBox.Checked = false;
            _forecast.OptArtPatinetTarget = Convert.ToInt32(e.Tag);
            _activeCheckBox = (LQTCheckBox)sender;
            _edited = true;
            OnNextButtonStatusChanged(EnableNextButton());
        }

        public override bool DoSomthingBeforeUnload()
        {
            if (_edited)
            {
                DataRepository.SaveOrUpdateMorbidityForecast(_forecast);
            }
            return true;
        }
    }
}
