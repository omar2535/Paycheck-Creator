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

namespace PaycheckCreator
{
    /// <summary>
    /// Interaction logic for InfoPage.xaml
    /// </summary>
    public partial class InfoPage : UserControl
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void NextButtonFromInfo_Click(object sender, RoutedEventArgs e)
        {

            ((MainWindow)System.Windows.Application.Current.MainWindow).creationForm.TabController.SelectedIndex = 1;
            
        }
    }
}
