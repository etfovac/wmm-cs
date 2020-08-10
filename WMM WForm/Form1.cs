using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TrueNorth.Geographic;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //MagVar MagnVarijacija = new MagVar();
            //double lat = 44.7429;
            //double lon = 20.4025;
            //double h = 0.15;
            //long dat = 2457134;
            //int model = 10;
            //double[] field = new double[6];
            //double Deklinacija = MagnVarijacija.SGMagVar(lat, lon, h, dat, model, field);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MagVar MagnVarijacija = new MagVar();
            double lat = MagnVarijacija.deg_to_rad(Convert.ToDouble(textBoxLAT.Text));
            double lon = MagnVarijacija.deg_to_rad(Convert.ToDouble(textBoxLONG.Text));
            double h = Convert.ToDouble(textBoxH.Text) / 1000;

            int yy = Convert.ToInt32(textBoxYY.Text);
            int mm = Convert.ToInt32(textBoxMM.Text);
            int dd = Convert.ToInt32(textBoxDD.Text);

            long dat = MagnVarijacija.yymmdd_to_julian_days(yy, mm, dd);
            int model = Convert.ToInt32(textBoxWMM.Text);
            double[] field = new double[6];
            double Deklinacija = MagnVarijacija.SGMagVar(lat, lon, h, dat, model, field);
            double Deklinacija_deg = MagnVarijacija.rad_to_deg(Deklinacija);
            label1.Text = Deklinacija.ToString();
            label2.Text = Deklinacija_deg.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            textBoxYY.Text = today.Year.ToString().Substring(2,2);
            textBoxMM.Text = today.Month.ToString();
            textBoxDD.Text = today.Day.ToString();
        }
    }
}
