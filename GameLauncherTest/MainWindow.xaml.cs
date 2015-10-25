using System;
using System.Windows;

using GameLauncherLibrary;
namespace GameLauncherTest
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

        private void websiteButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite("http://www.awfulmedia.com/");
        }

        private void launchButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayGame();
            Environment.Exit(0);
        }
    }
}
