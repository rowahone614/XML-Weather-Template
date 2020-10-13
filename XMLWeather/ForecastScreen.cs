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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }
        int weatherValue1, weatherValue2, weatherValue3, weatherValue4, weatherValue5, weatherValue6;
        public void displayForecast()
        {
            ForecastDetailColor();
            
            weatherValue1 = Convert.ToInt16(Form1.days[1].condition);
            weatherValue2 = Convert.ToInt16(Form1.days[2].condition);
            weatherValue3 = Convert.ToInt16(Form1.days[3].condition);
            weatherValue4 = Convert.ToInt16(Form1.days[4].condition);
            weatherValue5 = Convert.ToInt16(Form1.days[5].condition);
            weatherValue6 = Convert.ToInt16(Form1.days[6].condition);

            cityOutput.Text = Form1.days[0].location;

            date1Label.Text = Form1.days[1].date;
            day1LowLabel.Text = Form1.days[1].tempLow;
            day1HighLabel.Text = Form1.days[1].tempHigh;

            if (weatherValue1 == 800)
            {
                day1Icon.Image = Properties.Resources.sunIcon;
            }
            else if (weatherValue1 >= 200 && weatherValue1 <= 232)
            {
                day1Icon.Image = Properties.Resources.thunderIcon;
            }
            else if (weatherValue1 >= 300 && weatherValue1 <= 321)
            {
                day1Icon.Image = Properties.Resources.rainIcon;
            }
            else if (weatherValue1 >= 500 && weatherValue1 <= 531)
            {
                day1Icon.Image = Properties.Resources.rainIcon;
            }
            else if (weatherValue1 >= 600 && weatherValue1 <= 622)
            {
                day1Icon.Image = Properties.Resources.snowIcon;
            }
            else if (weatherValue1 >= 701 && weatherValue1 <= 781)
            {
                day1Icon.Image = Properties.Resources.hazeIcon;
            }
            else if (weatherValue1 >= 801 && weatherValue1 <= 804)
            {
                day1Icon.Image = Properties.Resources.cloudyIcon;
            }

            date2Label.Text = Form1.days[2].date;
            day2LowLabel.Text = Form1.days[2].tempLow;
            day2HighLabel.Text = Form1.days[2].tempHigh;

            if (weatherValue2 == 800)
            {
                day2Icon.Image = Properties.Resources.sunIcon;
            }
            else if (weatherValue2 >= 200 && weatherValue2 <= 232)
            {
                day2Icon.Image = Properties.Resources.thunderIcon;
            }
            else if (weatherValue2 >= 300 && weatherValue2 <= 321)
            {
                day2Icon.Image = Properties.Resources.rainIcon;
            }
            else if (weatherValue2 >= 500 && weatherValue2 <= 531)
            {
                day2Icon.Image = Properties.Resources.rainIcon;
            }
            else if (weatherValue2 >= 600 && weatherValue2 <= 622)
            {
                day2Icon.Image = Properties.Resources.snowIcon;
            }
            else if (weatherValue2 >= 701 && weatherValue2 <= 781)
            {
                day2Icon.Image = Properties.Resources.hazeIcon;
            }
            else if (weatherValue2 >= 801 && weatherValue2 <= 804)
            {
                day2Icon.Image = Properties.Resources.cloudyIcon;
            }

            date3Label.Text = Form1.days[3].date;
            day3LowLabel.Text = Form1.days[3].tempLow;
            day3HighLabel.Text = Form1.days[3].tempHigh;

            if (weatherValue3 == 800)
            {
                day3Icon.Image = Properties.Resources.sunIcon;
            }
            else if (weatherValue3 >= 200 && weatherValue3 <= 232)
            {
                day3Icon.Image = Properties.Resources.thunderIcon;
            }
            else if (weatherValue3 >= 300 && weatherValue3 <= 321)
            {
                day3Icon.Image = Properties.Resources.rainIcon;
            }
            else if (weatherValue3 >= 500 && weatherValue3 <= 531)
            {
                day3Icon.Image = Properties.Resources.rainIcon;
            }
            else if (weatherValue3 >= 600 && weatherValue3 <= 622)
            {
                day3Icon.Image = Properties.Resources.snowIcon;
            }
            else if (weatherValue3 >= 701 && weatherValue3 <= 781)
            {
                day3Icon.Image = Properties.Resources.hazeIcon;
            }
            else if (weatherValue3 >= 801 && weatherValue3 <= 804)
            {
                day3Icon.Image = Properties.Resources.cloudyIcon;
            }

            date4Label.Text = Form1.days[4].date;
            day4LowLabel.Text = Form1.days[4].tempLow;
            day4HighLabel.Text = Form1.days[4].tempHigh;

            if (weatherValue4 == 800)
            {
                day4Icon.Image = Properties.Resources.sunIcon;
            }
            else if (weatherValue4 >= 200 && weatherValue4 <= 232)
            {
                day4Icon.Image = Properties.Resources.thunderIcon;
            }
            else if (weatherValue4 >= 300 && weatherValue4 <= 321)
            {
                day4Icon.Image = Properties.Resources.rainIcon;
            }
            else if (weatherValue4 >= 500 && weatherValue4 <= 531)
            {
                day4Icon.Image = Properties.Resources.rainIcon;
            }
            else if (weatherValue4 >= 600 && weatherValue4 <= 622)
            {
                day4Icon.Image = Properties.Resources.snowIcon;
            }
            else if (weatherValue4 >= 701 && weatherValue4 <= 781)
            {
                day4Icon.Image = Properties.Resources.hazeIcon;
            }
            else if (weatherValue4 >= 801 && weatherValue4 <= 804)
            {
                day4Icon.Image = Properties.Resources.cloudyIcon;
            }

            date5Label.Text = Form1.days[5].date;
            day5LowLabel.Text = Form1.days[5].tempLow;
            day5HighLabel.Text = Form1.days[5].tempHigh;

            if (weatherValue5 == 800)
            {
                day5Icon.Image = Properties.Resources.sunIcon;
            }
            else if (weatherValue5 >= 200 && weatherValue5 <= 232)
            {
                day5Icon.Image = Properties.Resources.thunderIcon;
            }
            else if (weatherValue5 >= 300 && weatherValue5 <= 321)
            {
                day5Icon.Image = Properties.Resources.rainIcon;
            }
            else if (weatherValue5 >= 500 && weatherValue5 <= 531)
            {
                day5Icon.Image = Properties.Resources.rainIcon;
            }
            else if (weatherValue5 >= 600 && weatherValue5 <= 622)
            {
                day5Icon.Image = Properties.Resources.snowIcon;
            }
            else if (weatherValue5 >= 701 && weatherValue5 <= 781)
            {
                day5Icon.Image = Properties.Resources.hazeIcon;
            }
            else if (weatherValue5 >= 801 && weatherValue5 <= 804)
            {
                day5Icon.Image = Properties.Resources.cloudyIcon;
            }

            date6Label.Text = Form1.days[6].date;
            day6LowLabel.Text = Form1.days[6].tempLow;
            day6HighLabel.Text = Form1.days[6].tempHigh;

            if (weatherValue6 == 800)
            {
                day6Icon.Image = Properties.Resources.sunIcon;
            }
            else if (weatherValue6 >= 200 && weatherValue6 <= 232)
            {
                day6Icon.Image = Properties.Resources.thunderIcon;
            }
            else if (weatherValue6 >= 300 && weatherValue6 <= 321)
            {
                day6Icon.Image = Properties.Resources.rainIcon;
            }
            else if (weatherValue6 >= 500 && weatherValue6 <= 531)
            {
                day6Icon.Image = Properties.Resources.rainIcon;
            }
            else if (weatherValue6 >= 600 && weatherValue6 <= 622)
            {
                day6Icon.Image = Properties.Resources.snowIcon;
            }
            else if (weatherValue6 >= 701 && weatherValue6 <= 781)
            {
                day6Icon.Image = Properties.Resources.hazeIcon;
            }
            else if (weatherValue6 >= 801 && weatherValue6 <= 804)
            {
                day6Icon.Image = Properties.Resources.cloudyIcon;
            }
        }

        public void ForecastDetailColor()
        {
            if (CurrentScreen.weatherNumber == 800)
            {
                BackColor = Color.PowderBlue;
                AllTextGray();
            }
            else if (CurrentScreen.weatherNumber >= 200 && CurrentScreen.weatherNumber <= 232)
            {
                BackColor = Color.Gray;
                AllTextBlack();
            }
            else if (CurrentScreen.weatherNumber >= 300 && CurrentScreen.weatherNumber <= 321)
            {
                BackColor = Color.LightGray;
                AllTextBlack();
            }
            else if (CurrentScreen.weatherNumber >= 500 && CurrentScreen.weatherNumber <= 531)
            {
                BackColor = Color.Gray;
                AllTextBlack();
            }
            else if (CurrentScreen.weatherNumber >= 600 && CurrentScreen.weatherNumber <= 622)
            {
                BackColor = Color.White;
                AllTextGray();
            }
            else if (CurrentScreen.weatherNumber >= 701 && CurrentScreen.weatherNumber <= 781)
            {
                BackColor = Color.LightGray;
                AllTextBlack();
            }
            else if (CurrentScreen.weatherNumber >= 801 && CurrentScreen.weatherNumber <= 804)
            {
                BackColor = Color.CadetBlue;
                AllTextWhite();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        public void AllTextBlack()
        {
            cityOutput.ForeColor = Color.Black;
            todayLabel.ForeColor = Color.Black;
            forecastLabel.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            date1Label.ForeColor = Color.Black;
            date2Label.ForeColor = Color.Black;
            date3Label.ForeColor = Color.Black;
            date4Label.ForeColor = Color.Black;
            date5Label.ForeColor = Color.Black;
            date6Label.ForeColor = Color.Black;
        }

        public void AllTextWhite()
        {
            cityOutput.ForeColor = Color.White;
            todayLabel.ForeColor = Color.White;
            forecastLabel.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            date1Label.ForeColor = Color.White;
            date2Label.ForeColor = Color.White;
            date3Label.ForeColor = Color.White;
            date4Label.ForeColor = Color.White;
            date5Label.ForeColor = Color.White;
            date6Label.ForeColor = Color.White;
        }

        public void AllTextGray()
        {
            cityOutput.ForeColor = Color.DimGray;
            todayLabel.ForeColor = Color.DimGray;
            forecastLabel.ForeColor = Color.DimGray;
            label5.ForeColor = Color.DimGray;
            date1Label.ForeColor = Color.DimGray;
            date2Label.ForeColor = Color.DimGray;
            date3Label.ForeColor = Color.DimGray;
            date4Label.ForeColor = Color.DimGray;
            date5Label.ForeColor = Color.DimGray;
            date6Label.ForeColor = Color.DimGray;
        }
    }
}
