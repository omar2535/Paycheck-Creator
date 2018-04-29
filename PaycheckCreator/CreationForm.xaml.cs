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

namespace PaycheckCreator
{
    /// <summary>
    /// Interaction logic for CreationForm.xaml
    /// </summary>
    public partial class CreationForm : Window
    {
        List<string> _items = new List<string>();
        int i = 0;
        public CreationForm()
        {
            InitializeComponent();
            _items.Add("One"); // <-- Add these
            _items.Add("Two");
            _items.Add("Three");
            listbox.ItemsSource = _items;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("BUTTON CLICK");
            _items.Add("Four");
            listbox.ItemsSource = null;
            listbox.ItemsSource = _items;
        }
    }
}
