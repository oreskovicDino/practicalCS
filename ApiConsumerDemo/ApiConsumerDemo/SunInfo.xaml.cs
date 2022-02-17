﻿namespace ApiConsumerDemo
{
    using DemoLibrary;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Shapes;

    /// <summary>
    /// Interaction logic for SunInfo.xaml
    /// </summary>
    public partial class SunInfo : Window
    {
        public SunInfo()
        {
            InitializeComponent();
        }

        private async void loadSunInfo_Click(object sender, RoutedEventArgs e)
        {
            var sunInfo = await SunProcessor.LoadSunInformation();
            sunriseText.Text = $"Sunrise is at { sunInfo.SunRise.ToLocalTime().ToShortTimeString() }";
            sunsetText.Text = $"Sunset is at { sunInfo.SunSet.ToLocalTime().ToShortTimeString() }";
        }
    }
}
