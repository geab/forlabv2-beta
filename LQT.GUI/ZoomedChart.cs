using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LQT.Core.Domain;
using LQT.Core.Util;
using LQT.GUI.Location;
using LQT.Core.UserExceptions;
using System.Windows.Forms.DataVisualization.Charting;

namespace LQT.GUI
{
    public partial class ZoomedChart : Form
    {
        private Chart _currentchart;

        public ZoomedChart(Chart _chart)
        {
            _currentchart = _chart;
          //  _currentchart.ContextMenuStrip = null;
            _currentchart.Dock = DockStyle.Fill;
            this.Controls.Add(_currentchart);
            InitializeComponent();
        }

        private void ZoomedChart_Load(object sender, EventArgs e)
        {

        }
    }
}
