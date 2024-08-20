﻿using System.Net.Http;
using System.Windows;

namespace AsyncWebDotUser
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync("http://localhost:5191");
            var result = await response.Content.ReadAsStringAsync();
            MessageBox.Show(result);
        }
    }
}