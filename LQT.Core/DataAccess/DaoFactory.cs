﻿using System;
using System.Configuration;
using LQT.Core.DataAccess.Interface;

namespace LQT.Core.DataAccess
{
    public class DaoFactory
    {
        public DaoFactory()
        {

        }

        public static DaoFactory GetDaoFactory()
        {
            return new NHibernateDaoFactory();
        }

        public virtual ITestDao CreateTestDao()
        {
            throw new NotImplementedException();
        }

        public virtual ITestingAreaDao CreateTestingAreaDao()
        {
            throw new NotImplementedException();
        }

      

        public virtual IForlabRegionDao CreateRegionDao()
        {
            throw new NotImplementedException();
        }

        public virtual IForlabSiteDao CreateSiteDao()
        {
            throw new NotImplementedException();
        }

        public virtual IInstrumentDao CreateInstrumentDao()
        {
            throw new NotImplementedException();
        }

        public virtual IProductDao CreateProductDao()
        {
            throw new NotImplementedException();
        }

        public virtual IProductTypeDao CreateProductTypeDao()
        {
            throw new NotImplementedException();
        }

        public virtual IForecastInfoDao CreateForecastInfoDao()
        {
            throw new NotImplementedException();
        }

        public virtual IForecastCategoryDao CreateForecastCategoryDao()
        {
            throw new NotImplementedException();
        }

        public virtual IForecastSiteDao CreateForecastSiteDao()
        {
            throw new NotImplementedException();
        }

        public virtual IForecastSiteProductDao CreateForecastSiteProductDao()
        {
            throw new NotImplementedException();
        }

        public virtual IForecastCategoryProductDao CreateForecastCategoryProductDao()
        {
            throw new NotImplementedException();
        }

        public virtual IForecastSiteTestDao CreateForecastSiteTestDao()
        {
            throw new NotImplementedException();
        }

        public virtual IForecastCategoryTestDao CreateForecastCategoryTestDao()
        {
            throw new NotImplementedException();
        }
        public virtual IFTableDao CreateFTableDao()
        {
            throw new NotImplementedException();
        }
        public virtual ISiteCategoryDao CreateSiteCategoryDao()
        {
            throw new NotImplementedException();
        }

        public virtual IForecastedResultDao CreateForecastedResultDao()
        {
            throw new NotImplementedException();
        }

       
        public virtual IMorbidityForecastDao CreateMorbidityForecastDao()
        {
            throw new NotImplementedException();   
        }

        public virtual IRapidTestSpecDao CreateRapidTestSpecDao()
        {
            throw new NotImplementedException();
        }
               

        public virtual IARTSiteDao CreateARTSiteDao()
        {
            throw new NotImplementedException();
        }

        
        public virtual IMorbiditySupplyForecastDao CreateMorbiditySupplyForecastDao()
        {
            throw new NotImplementedException();
        }

        public virtual IMorbiditySupplyProcurementDao CreateMorbiditySupplyProcurementDao()
        {
            throw new NotImplementedException();
        }
        public virtual IProtocolDao CreateProtocolDao()
        {
            throw new NotImplementedException();
        }
        public virtual IProtocolPanelDao CreateProtocolPanelDao()
        {
            throw new NotImplementedException();
        }

        public virtual IPatientsNoofTestDao CreatePatientsNoofTestDao()
        {
            throw new NotImplementedException();
        }

        public virtual IHIVRapidNumberofTestDao CreateHIVRapidNumberofTestDao()
        {
            throw new NotImplementedException();
        }

        public virtual IHemaandViralNumberofTestDao CreateHemaandViralNumberofTestDao()
        {
            throw new NotImplementedException();
        }

        public virtual ICD4TestNumberDao CreateCD4TestNumberDao()
        {
            throw new NotImplementedException();
        }

        public virtual IChemandOtherNumberofTestDao CreateChemandOtherNumberofTestDao()
        {
            throw new NotImplementedException();
        }

        public virtual IForlabParameterDao CreateForlabParameterDao()
        {
            throw new NotImplementedException();
        }

        public virtual IInventoryAssumptionDao CreateInventoryAssumptionDao()
        {
            throw new NotImplementedException();
        }

        public virtual IMorbidityTestDao CreateMorbidityTestDao()
        {
            throw new NotImplementedException();
        }

        public virtual IQuantifyMenuDao CreateQuantifyMenuDao()
        {
            throw new NotImplementedException();
        }
        public virtual IQuantificationMetricDao CreateQuantificationMetricDao()
        {
            throw new NotImplementedException();
        }
        public virtual IForecastCategoryInstrumentDao CreateForecastCategoryInstrumentDao()
        {
            throw new NotImplementedException();
        }

        public virtual IConsumableDao CreateConsumableDao()
        {
            throw new NotImplementedException();
        }

        public virtual IConsumableUsageDao CreateConsumableUsageDao()
        {
            throw new NotImplementedException();
        }

        public virtual IProductUsageDao CreateProductUsageDao()
        {
            throw new NotImplementedException();
        }
        
    }

}
