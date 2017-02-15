﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LQT.Core;
using LQT.Core.Util;
using LQT.Core.Domain;

namespace LQT.GUI.MorbidityUserCtr
{
    public partial class OpEverStartedPatientTarget : BaseMorbidityControl
    {
        private LQTCheckBox _activeCheckBox;
        private MorbidityForecast _forecast;
        private bool _edited = false;

        public OpEverStartedPatientTarget(MorbidityForecast forecast)
        {
            this._forecast = forecast;
            InitializeComponent();

            if (forecast.OptEverStartedPatientTarget > 0)
            {
                switch (forecast.EverStartedPatientTargetEnum)
                {
                    case OptEverStartedPatientTargetEnum.RecentData:
                        _activeCheckBox = chbRecentdata;
                        break;
                    case OptEverStartedPatientTargetEnum.OldData:
                        _activeCheckBox = chbOlddata;
                        break;
                    case OptEverStartedPatientTargetEnum.NoData:
                        _activeCheckBox = chbNodata;
                        break;
                }
                _activeCheckBox.Checked = true;
            }
            else
            {
                OnNextButtonStatusChanged(false);
            }

            chbNodata.LQTCheckBoxClick += new EventHandler<LQTCheckBoxEvenArgs>(LQTCheckBoxClick);
            chbOlddata.LQTCheckBoxClick += new EventHandler<LQTCheckBoxEvenArgs>(LQTCheckBoxClick);
            chbRecentdata.LQTCheckBoxClick += new EventHandler<LQTCheckBoxEvenArgs>(LQTCheckBoxClick);
        }
        public override string Title
        {
            get { return "Patients Ever Started On Treatment"; }
        }

        public override string Description
        {
            get
            {
                string desc="If you measure your patient treatment targets based on the number of patients ";
                desc +="that have EVER STARTED ON TREATMENT by the end of the forecast period, an extra step is required. ";
                desc +="If you chose Option 2 on the previous screen, this screen will appear asking you to select a method ";
                desc += "for establishing a baseline of how many patients were EVER STARTED ON TREATMENT before the forecast time period.";

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
                if (_forecast.EverStartedPatientTargetEnum == OptEverStartedPatientTargetEnum.RecentData)
                    return MorbidityCtrEnum.EverStartedRecentData;
                if (_forecast.EverStartedPatientTargetEnum == OptEverStartedPatientTargetEnum.OldData)
                    return MorbidityCtrEnum.EverStartedOldData;
                if (_forecast.EverStartedPatientTargetEnum == OptEverStartedPatientTargetEnum.NoData)
                    return MorbidityCtrEnum.EverStartedNoData;

                return MorbidityCtrEnum.Nothing;
            }
        }

        public override bool EnableNextButton()
        {
            return _forecast.OptEverStartedPatientTarget > 0;
        }

        private void LQTCheckBoxClick(object sender, LQTCheckBoxEvenArgs e)
        {
            if (_activeCheckBox != null)
                _activeCheckBox.Checked = false;
            _forecast.OptEverStartedPatientTarget = Convert.ToInt32(e.Tag);
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
