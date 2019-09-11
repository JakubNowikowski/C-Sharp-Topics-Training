using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsynchronousProgramming_AsyncAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetButton_Click(object sender, RoutedEventArgs e)
        {
            var html = GetHtml();

            MessageBox.Show(html.Substring(0,10000));
        }

        public string GetHtml()
        {
            var webClient = new WebClient();
            return webClient.DownloadString("http://github.com");
        }

        private async void GetAsyncButton_Click(object sender, RoutedEventArgs e)
        {
            var html = await GetHtmlAsync();
            MessageBox.Show(html.Substring(0, 10000));
        }

        public async Task<string> GetHtmlAsync()
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync("http://github.com");
        }
    }
}
