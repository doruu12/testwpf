using System.Diagnostics;
using System.Net.Http;
using System.Windows;

using Microsoft.Web.WebView2.Core;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HttpClient httpClient { get; } = new HttpClient();

        public MainWindow()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            await webView.EnsureCoreWebView2Async(null);
            //webView.CoreWebView2.Navigate("pack://application:,,,/map.html");

            // Construct the file URI for map.html
            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "map.html");
            string fileUri = new Uri(filePath).AbsoluteUri;

            webView.CoreWebView2.Navigate(fileUri);
        }

        private void webView_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            //Debugger.Break();
        }

        private void btnAction1_Click(object sender, RoutedEventArgs e)
        {
            var pinList = "[{'id':1,'lat':'26.096','long':'44.439'}, {'id':2,'lat':'26.086','long':'44.439'}]";
            webView.ExecuteScriptAsync($"addPin({pinList})");
        }

        private async void btnAction2_Click(object sender, RoutedEventArgs e)
        {
            var url = "http://localhost:5000/Api/LoadAllPositions";
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                webView.ExecuteScriptAsync($"addPin({content})");
            }
        }

        private async void btnAction3_Click(object sender, RoutedEventArgs e)
        {
            var url = "http://localhost:5000/Api/LoadSoldierMovement?soldierId=1";
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                webView.ExecuteScriptAsync($"addPin({content})");
            }

        }
    }
}