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
        private int x = 0;
        private double number = 0.00;
        //List<DeductionItem> items = new List<DeductionItem>();
        public CreationForm()
        {
            InitializeComponent();
            WarningText.Opacity = 0;
            WarningText1.Opacity = 0;
            WarningText2.Opacity = 0;

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
            //items.Add(deductionItem);
            if (finalLegalityCheck()) {
                DeductionDisplay.Items.Add(deductionItem);
            }
            

        }

        //Actions when form changes
        private void PercentageAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkIfLegalAmount(WarningText, (TextBox)sender);
        }

        private void FlatAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkIfLegalAmount(WarningText1, (TextBox)sender);
        }
        private void NameOfDeduction_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox text = (TextBox)sender;
            if(text.Background != Brushes.White)
                text.Background = Brushes.White;
            if (WarningText2.Opacity == 100 && text.Text != "") {
                WarningText2.Opacity = 0;
            }
        }


        //Helper for checking if amount is deduction amount is legal integers
        private void checkIfLegalAmount(TextBlock block, TextBox form) {
            if (Int32.TryParse(form.Text, out x) || form.Text == "")
            {
                block.Opacity = 0;
                form.Background = Brushes.White;
            }
            else if (Double.TryParse(form.Text, out number)) {
                block.Opacity = 0;
                form.Background = Brushes.White;
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

        //Perform Legality check before submitting
        private bool finalLegalityCheck() {
            if (WarningText.Opacity == 100)
            {
                PercentageAmount.Background = Brushes.LightPink;
            }
            if (WarningText1.Opacity == 100)
            {
                FlatAmount.Background = Brushes.LightPink;
            }
            if (NameOfDeduction.Text == "") {
                WarningText2.Opacity = 100;
                NameOfDeduction.Background = Brushes.LightPink;
            }
            else
            {
                if (WarningText.Opacity == 0 && WarningText1.Opacity == 0)
                {
                    PercentageAmount.Background = Brushes.White;
                    FlatAmount.Background = Brushes.White;
                    NameOfDeduction.Background = Brushes.White;
                    return true;
                }
            }
            return false;
        }


    }
}
