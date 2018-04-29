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
        List<DeductionItem> items = new List<DeductionItem>();
        int i = 0;
        public CreationForm()
        {
            InitializeComponent();

        }

        private void addedNewDeduction(object sender, RoutedEventArgs e)
        {
            string text = NameOfDeduction.Text;
            int percentageAmount = Int32.Parse(PercentageAmount.Text);
            int flatAmount = Int32.Parse(FlatAmount.Text);
            DeductionItem deductionItem = new DeductionItem();
            deductionItem.NameOfDeduction = text;
            deductionItem.PercentageAmount = percentageAmount;
            deductionItem.FlatAmount = flatAmount;
            DeductionDisplay.Items.Add(deductionItem);

        }


    }
}
