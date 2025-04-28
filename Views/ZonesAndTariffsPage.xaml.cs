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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComputerClubDiplom.Views
{
    /// <summary>
    /// Логика взаимодействия для ZonesAndTariffsPage.xaml
    /// </summary>
    public partial class ZonesAndTariffsPage : Page
    {
        public ZonesAndTariffsPage()
        {
            InitializeComponent();
        }

		private void EditTariffsButton_Click(object sender, RoutedEventArgs e)
		{
			EditTariffsWindow window = new EditTariffsWindow();
			window.ShowDialog();
		}
	}
}
