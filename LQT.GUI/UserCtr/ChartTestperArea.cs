using System;
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
    public partial class ChartTestperArea : LQT.GUI.UserCtr.BaseUserControl
    {
        private IList<TestingArea> _testArea;
        public ChartTestperArea()
        {
            InitializeComponent();
        }

        private void ChartTestperArea_Load(object sender, EventArgs e)
        {
            //no tests per area
            _testArea = DataRepository.GetAllTestingArea();
            int[] testcount = new int[_testArea.Count];
            string[] areas = new string[_testArea.Count];
            for (int i = 0; i < _testArea.Count; i++)
            {
                areas[i] = _testArea[i].AreaName;
                testcount[i] = _testArea[i].Tests.Count;
            }

            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.IsEndLabelVisible = true;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLabelAutoFit = true;

            chart1.Series["testperarea"]["PointWidth"] = "0.4";
            chart1.Series["testperarea"].Points.DataBindXY(areas, testcount);
        }

       

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
