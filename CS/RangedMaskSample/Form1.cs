using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RangedMaskSample;

namespace RangedMaskSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaskElementsRepository.MaskCollection.Add(new MaskElement("a1", 0, 10));
            MaskElementsRepository.MaskCollection.Add(new MaskElement("c3", 15, 125));
        }
    }
}