﻿using ShowWpfWindow1Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowWpfWindowFromLibExecutorApp
{
    public partial class Form1 : Form
    {
        public WindowExhibitor Exhibitor { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowWindow_Click(object sender, EventArgs e)
        {
            Exhibitor = new WindowExhibitor();
            Exhibitor.InitWindow("E:\\Temp\\Pictures\\InitialPicture.jpg");
        }

        private void btnShowPict1_Click(object sender, EventArgs e)
        {
            if(Exhibitor != null)
                Exhibitor.ShowPicture("E:\\Temp\\Pictures\\Electronics1.jpg");
        }

        private void btnShowPict2_Click(object sender, EventArgs e)
        {
            if (Exhibitor != null)
                Exhibitor.ShowPicture("E:\\Temp\\Pictures\\Electronics2.jpg");
        }

        private void btnHideWindow_Click(object sender, EventArgs e)
        {
            if (Exhibitor != null)
                Exhibitor.ShowHideWindow(false);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (Exhibitor != null)
                Exhibitor.ShowHideWindow(true);
        }
    }
}
