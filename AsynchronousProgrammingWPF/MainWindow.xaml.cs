using System;
using System.Collections.Generic;
using System.IO;
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

namespace AsynchronousProgrammingWPF
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

        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);
            //using (var streamWriter = new StreamWriter(System.IO.Path.Combine(Environment.CurrentDirectory,"projectResult.txt"))
            using (var streamWriter = new StreamWriter(@"some file path here"))
            {
                await streamWriter.WriteAsync(html);
            }
        }
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            //using (var streamWriter = new StreamWriter(System.IO.Path.Combine(Environment.CurrentDirectory,"projectResult.txt"))
            using (var streamWriter = new StreamWriter(@"projectResult.txt"))
            {
                streamWriter.Write(html);
            }
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //DownloadHtml("https://msdn.microsoft.com/en-us/");
            var gethtmltask = GetHtmlAsync("https://msdn.microsoft.com/en-us/");
            MessageBox.Show("Waiting for your task to complete...");
            
            var html = await gethtmltask;
            MessageBox.Show(html.Substring(0, 10));
        }
    }
}
