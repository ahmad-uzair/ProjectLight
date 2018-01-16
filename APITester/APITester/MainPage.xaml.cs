using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APITester
{
    public partial class MainPage : ContentPage
    {
        HttpClient client;
        public MainPage()
        {
            InitializeComponent();
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            const string RestUrl = "https://projectlight.onlosant.com/gpio/2";
            var uri = new Uri(string.Format(RestUrl, string.Empty));
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                //var content = await response.Content.ReadAsStringAsync();
                //ResultLabel.Text = content;
            }
            const string RestUrl2 = "https://projectlight.onlosant.com/devices/5a5233088cc82100078f0dd6/data";
            var uri2 = new Uri(string.Format(RestUrl2, string.Empty));
            var response2 = await client.GetAsync(uri2);
            if (response2.IsSuccessStatusCode)
            {
                var content2 = await response2.Content.ReadAsStringAsync();
                ResultLabel.Text = content2;
            }
        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            const string RestUrl = "https://projectlight.onlosant.com/gpio/3";
            var uri = new Uri(string.Format(RestUrl, string.Empty));
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                //ResultLabel.Text = content;
            }
        }

        async private void Button_Clicked_2(object sender, EventArgs e)
        {
            const string RestUrl = "https://projectlight.onlosant.com/gpio/4";
            var uri = new Uri(string.Format(RestUrl, string.Empty));
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                //ResultLabel.Text = content;
            }
        }

        async private void Button_Clicked_3(object sender, EventArgs e)
        {
            const string RestUrl = "https://projectlight.onlosant.com/gpio/17";
            var uri = new Uri(string.Format(RestUrl, string.Empty));
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                //ResultLabel.Text = content;
            }
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {

        }
    }
}
