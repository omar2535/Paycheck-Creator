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
        double number = 0.00;
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
            double percentageAmount = parseString<Double>(PercentageAmount.Text);
            double flatAmount = parseString<Double>(FlatAmount.Text);
            
            DeductionItem deductionItem = new DeductionItem();
            deductionItem.NameOfDeduction = text;
            deductionItem.PercentageAmount = percentageAmount;
            deductionItem.FlatAmount = flatAmount;
            DeductionDisplay.Items.Add(deductionItem);
        }

        private void PercentageAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkIfLegalAmount(WarningText, (TextBox)sender);
        }

        private void FlatAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkIfLegalAmount(WarningText1, (TextBox)sender);
        }



        //Helper for checking if amount is deduction amount is legal integers
        private void checkIfLegalAmount(TextBlock block, TextBox form) {
            if (Int32.TryParse(form.Text, out x) || form.Text == "")
            {
                block.Opacity = 0;
            }
            else if (Double.TryParse(form.Text, out number)) {
                block.Opacity = 0;
            }
            else {
                block.Opacity = 100;
            }
        }

        //converts string to either int or double
        private T parseString<T>(string inputString) {
            if (Int32.TryParse(inputString, out x))
            {
                return (T) System.Convert.ChangeType(x, Type.GetTypeCode(typeof(T)));
            }
            else if (Double.TryParse(inputString, out number))
            {
                return (T)System.Convert.ChangeType(number, Type.GetTypeCode(typeof(T)));
            }
            else {
                return (T)System.Convert.ChangeType(0, Type.GetTypeCode(typeof(T)));
            }
        }
    }
}
