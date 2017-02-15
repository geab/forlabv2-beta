﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LQT.GUI
{
    public partial class CustomToolTip : UserControl
    {
        public CustomToolTip(string title, string description)
        {
            InitializeComponent();
            this.lblTitle.Text = title;
            this.lblDescription.Text = description;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Brush b = new LinearGradientBrush(ClientRectangle, Color.White, BackColor, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(b, ClientRectangle);
            }

            using (Pen p = new Pen(Color.FromArgb(118, 118, 118)))
            {
                Rectangle rect = ClientRectangle;
                rect.Width--;
                rect.Height--;
                e.Graphics.DrawRectangle(p, rect);
            }
        }
    }
}
