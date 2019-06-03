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
            //calculate the area of a rectangle
            //tests the code for errors
            try
            {
                double Width, Height, Area;

                Width = Convert.ToDouble(WidthBox.Text);

                Height = Convert.ToDouble(HeightBox.Text);

                Area = Width * Height;

                AreaOut.Text = "Area = " + Area;
            }
            // will reply to the error that is found
            catch
            {
                MessageBox.Show("type in two numbers!");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double Base, Height, Area;

                Base = Convert.ToDouble(BaseBox.Text);

                Height = Convert.ToDouble(Heightbox2.Text);

                Area = Base * Height;

                Area1 = Area / 2;

                Areaout2.Text = "Area =" + Area1;
            }
            catch
            {
                MessageBox.Show("Type in Two Numbers!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Double Radius, Area;

                Radius = Convert.ToDouble(RadiusBox.Text);

                Area = 
            }
        }
    }
}
