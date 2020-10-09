using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }
        int weatherNumber;
        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp;
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;
            weatherNumber = Convert.ToInt16(Form1.days[0].condition);
            if (weatherNumber == 800)
            {
                currentOutput.Text = "with a clear sky.";
                BackColor = Color.PowderBlue;
                AllTextGray();
                iconBox.Image = Properties.Resources.sunIcon;
            }
            else if (weatherNumber >= 200 || weatherNumber <= 232)
            {
                currentOutput.Text = "with thunderstorms.";
                BackColor = Color.Gray;
                AllTextBlack();
                iconBox.Image = Properties.Resources.thunderIcon;
            }
            else if (weatherNumber >= 300 || weatherNumber <= 321)
            {
                currentOutput.Text = "with some drizzle.";
                BackColor = Color.LightGray;
                AllTextBlack();
                iconBox.Image = Properties.Resources.rainIcon;
            }
            else if (weatherNumber >= 500 || weatherNumber <= 531)
            {
                currentOutput.Text = "with rain.";
                BackColor = Color.Gray;
                AllTextBlack();
                iconBox.Image = Properties.Resources.rainIcon;
            }
            else if (weatherNumber >= 600 || weatherNumber <= 622)
            {
                currentOutput.Text = "with snow.";
                BackColor = Color.White;
                AllTextGray();
                iconBox.Image = Properties.Resources.snowIcon;
            }
            else if (weatherNumber >= 701 || weatherNumber <= 781)
            {
                currentOutput.Text = "with haze.";
                BackColor = Color.LightGray;
                AllTextBlack();
                iconBox.Image = Properties.Resources.hazeIcon;
            }
            else if (weatherNumber >= 801 || weatherNumber <= 804)
            {
                currentOutput.Text = "and cloudy.";
                BackColor = Color.CadetBlue;
                AllTextWhite();
                iconBox.Image = Properties.Resources.cloudyIcon;
            }

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        public void AllTextBlack()
        {
            cityOutput.ForeColor = Color.Black;
            todayLabel.ForeColor = Color.Black;
            forecastLabel.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            titleLabel.ForeColor = Color.Black;
            tempLabel.ForeColor = Color.Black;
            currentOutput.ForeColor = Color.Black;
            symbolLabel.ForeColor = Color.Black;
            symbolLabel2.ForeColor = Color.Black;
            symbolLabel3.ForeColor = Color.Black;
        }

        public void AllTextWhite()
        {
            cityOutput.ForeColor = Color.White;
            todayLabel.ForeColor = Color.White;
            forecastLabel.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            titleLabel.ForeColor = Color.White;
            tempLabel.ForeColor = Color.White;
            currentOutput.ForeColor = Color.White;
            symbolLabel.ForeColor = Color.White;
            symbolLabel2.ForeColor = Color.White;
            symbolLabel3.ForeColor = Color.White;
        }

        public void AllTextGray()
        {
            cityOutput.ForeColor = Color.DimGray;
            todayLabel.ForeColor = Color.DimGray;
            forecastLabel.ForeColor = Color.DimGray;
            label5.ForeColor = Color.DimGray;
            titleLabel.ForeColor = Color.DimGray;
            tempLabel.ForeColor = Color.DimGray;
            currentOutput.ForeColor = Color.DimGray;
            symbolLabel.ForeColor = Color.DimGray;
            symbolLabel2.ForeColor = Color.DimGray;
            symbolLabel3.ForeColor = Color.DimGray;
        }
    }
}
