﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LQT.Core.Domain;
using LQT.Core.UserExceptions;
using LQT.Core.Util;

namespace LQT.GUI.UserCtr
{
    public partial class ProductNoperCat : LQT.GUI.UserCtr.BaseUserControl
    {
       
        private IList<ProductType> _productType;
        public ProductNoperCat()
        {
            InitializeComponent();
        }

        private void ProductNoperCat_Load(object sender, EventArgs e)
        {
            _productType = DataRepository.GetAllProductType();

            //No of product per category
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.IsEndLabelVisible = true;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLabelAutoFit = true;

            int[] pcount = new int[_productType.Count];

            string[] productT = new string[_productType.Count];

            for (int i = 0; i < _productType.Count; i++)
            {
                pcount[i] = _productType[i].Products.Count;
                productT[i] = _productType[i].TypeName;
            }

            chart1.Series["Pcount"]["PointWidth"] = "0.4";
            chart1.Series["Pcount"].Points.DataBindXY(productT, pcount);
        }
    }
}
