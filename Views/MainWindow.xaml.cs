using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ComputerClubDiplom.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClubMap_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("../Views/ClubMapPage.xaml", UriKind.Relative));

		}

        private void MainPageButton_Click(object sender, RoutedEventArgs e)
        {
			MainFrame.Navigate(new Uri("../Views/MainPage.xaml", UriKind.Relative));
		}

		private void BookingPageButton_Click(object sender, RoutedEventArgs e)
		{
			MainFrame.Navigate(new Uri("../Views/BookingPage.xaml", UriKind.Relative));
		}

		private void UsersPageButton_Click(object sender, RoutedEventArgs e)
		{
			MainFrame.Navigate(new Uri("../Views/UsersPage.xaml", UriKind.Relative));
		}

		private void ZonesAndTariffsPageButton_Click(object sender, RoutedEventArgs e)
		{
			MainFrame.Navigate(new Uri("../Views/ZonesAndTariffsPage.xaml", UriKind.Relative));
		}
	}
}
