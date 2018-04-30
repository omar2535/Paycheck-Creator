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
        int x = 0;
        List<DeductionItem> items = new List<DeductionItem>();
        public CreationForm()
        {
            InitializeComponent();
            WarningText.Opacity = 0;
            WarningText1.Opacity = 0;

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

        private void PercentageAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkIfLegalAmount(WarningText);
        }

        private void FlatAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkIfLegalAmount(WarningText1);
        }



        //Helper for checking if amount is deduction amount is legal integers
        private void checkIfLegalAmount(TextBlock block) {
            if (Int32.TryParse(PercentageAmount.Text, out x) || PercentageAmount.Text == "")
            {
                block.Opacity = 0;
            }
            else
            {
                block.Opacity = 100;
            }
        }
    }
}
