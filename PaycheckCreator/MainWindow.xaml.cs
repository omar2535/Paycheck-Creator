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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CreationForm creationForm;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            this.creationForm = new CreationForm();
            creationForm.Show();
            
            //this.Hide();
            //Console.WriteLine("Start button was clicked");
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Load button was clicked");
            //TODO: Complete loading paycheck file
        }

        public CreationForm getCreationForm() {
            return this.creationForm;
        }
    }
}
