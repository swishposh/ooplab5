﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop5_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            galery1.images.Add(Properties.Resources.im1);
            galery1.images.Add(Properties.Resources.im4);
            galery1.images.Add(Properties.Resources.im3);

            circle1.images.Add(Properties.Resources.im7);
            circle1.images.Add(Properties.Resources.im2);
            circle1.images.Add(Properties.Resources.im8);
        }

        private void galery1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
