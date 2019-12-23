using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace testAPI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetTest();
        }

        private async void GetTest()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("https://still-ridge-37958.herokuapp.com/wallet/5dff6ba454a300189368d429?fbclid=IwAR3yVD5fCP6g0Uz93ybmho0UByUG6Mm1NmDdeEKU4H9DojQsyyMNnXo0jn4");
            var test = JsonConvert.DeserializeObject<List<test>>(response);
            TestListView.ItemsSource = test;
        }
    }
}
