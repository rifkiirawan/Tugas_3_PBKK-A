using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Live_Currency_Exchange
{
    public partial class excForm : Form
    {
        public excForm()
        {
            InitializeComponent();

            // Buat label5 (label yang menunjukkan uang hasil convert) menjadi null
            label5.Text = "";

            getCurrencyList();
        }

        private void excForm_Load(object sender, EventArgs e)
        {

        }

        private void conv_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currExc.Text))
            {
                label5.Text = "Please enter the amount.";
                label5.ForeColor = Color.DarkRed;
            }
            else
            {
                if(string.IsNullOrEmpty(fromBox.Text) || string.IsNullOrEmpty(toBox.Text))
                {
                    label5.Text = "Please check the currency that you want to convert.";
                    label5.ForeColor = Color.DarkRed;
                }
                else
                {
                    double input = Convert.ToDouble(currExc.Text);
                    double rates = ExchangeRate(fromBox.Text, toBox.Text, dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                    input = input * rates;

                    label5.Text = "Converted Amount : " + Convert.ToString(input);
                    label5.ForeColor = Color.Black;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void getCurrencyList()
        {
            API currencyListRequest = new API("https://free.currconv.com/api/v7/currencies?apiKey=809dd5e23f7c7be3ab59");
            currencyList currencyList = currencyList.Deserialize(currencyListRequest.SendAndGetResponse());

            CurrencyData[] datas = currencyList.ToArray();
            foreach (CurrencyData currency in datas)
            {
                fromBox.Items.Add(currency.id);
                toBox.Items.Add(currency.id);
            }
        }
        public static double ExchangeRate(string from, string to, string date)
        {
            string url;
            url = "https://free.currencyconverterapi.com/api/v6/" + "convert?q=" + from + "_" + to + "&compact=y&date=" + date + "&apiKey=809dd5e23f7c7be3ab59";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            string jsonString;
            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                jsonString = reader.ReadToEnd();
            }

            return JObject.Parse(jsonString).First.First["val"].First.ToObject<double>();
        }
    }
}
