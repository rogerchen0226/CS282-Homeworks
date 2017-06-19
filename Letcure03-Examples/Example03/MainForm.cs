using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeatherStationsLibrary;

namespace Example03
{
    public partial class MainForm : Form
    {
        private WeatherData data;

        public MainForm()
        {
            InitializeComponent();

            data = new WeatherData()
            {
                Temperature = 30.32,
                Humidity = 90.8921,
                Pressure = 1
            };
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            temperatureLabel.Text = String.Format("溫度 : {0}", data.Temperature.ToString());
            humidityLabel.Text = String.Format("溼度 : {0}", data.Humidity.ToString("#.#"));
            pressureLabel.Text = String.Format("壓力 : {0}", data.Pressure.ToString("#.#"));
        }
    }
}