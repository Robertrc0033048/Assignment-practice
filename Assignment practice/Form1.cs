using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Width, Height, Area;

            Width = Convert.ToDouble(WidthBox.Text);

            Height = Convert.ToDouble(HeightBox.Text);

            Area = Width * Height;

            AreaOut.Text = "Area = " + Area;

        }
    }
}
