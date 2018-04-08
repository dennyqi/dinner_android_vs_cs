using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace dinner_android_vs_cs
{
    [Activity(Label = "dinner_android_vs_cs_long", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            TextView dinner_date = FindViewById<TextView>(Resource.Id.textView1);
            Button orderButton = FindViewById<Button>(Resource.Id.button1);
            dinner_date.Text = System.DateTime.Now.ToString();

            // Add code to order dinner
            orderButton.Click += (sender, e) =>
            {
                string URL = "https://docs.google.com/forms/d/e/1FAIpQLScTdzkph5DHlg4W3qZgoQ8gy0YNPDEMcuCpUJIkD1M4831_hw/formResponse";
                var httpClient = new HttpClient();
                //httpClient.BaseAddress = new Uri("https://docs.google.com/forms/d/e/1FAIpQLScTdzkph5DHlg4W3qZgoQ8gy0YNPDEMcuCpUJIkD1M4831_hw/formResponse");
                //httpClient.BaseAddress = new Uri("https://docs.google.com/forms/d/e/1FAIpQLScTdzkph5DHlg4W3qZgoQ8gy0YNPDEMcuCpUJIkD1M4831_hw/formResponse");
                var content = new StringContent("entry.584591229 = Denny Qi", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                httpClient.PostAsync(URL, content);
                //HttpClient client;
                //var client = new HttpClient();
                //client.BaseAddress = new Uri("http://localhost");
                // Translate user's alphanumeric phone number to numeric
                //translatedPhoneWord.Text = "What is going on ?";
                //translatedPhoneWord.Text = phoneNumberText.Text;
                //translatedPhoneWord.Text = dateText.Text;

            };

        }
    }
}

