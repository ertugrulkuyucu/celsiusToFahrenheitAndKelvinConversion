using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace celsiusDonusum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {

            double kelvin, fahrenheit;


            double celsius = 0;
            celsius = Convert.ToSingle(celsiusText.Text);

            kelvin = celsius + 273.15d;
            fahrenheit = (celsius * 9d / 5d) + 32d;

            fahrenheitTxt.Text = fahrenheit.ToString();
            kelvinTxt.Text = kelvin.ToString();
              
            // deneme

        }

        private void fahrenheitTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
