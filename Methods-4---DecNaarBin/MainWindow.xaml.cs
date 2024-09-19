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

namespace Methods_4___DecNaarBin
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

        private string DecimalToBinary(uint decimalNumber)
        {
            // Start met minstens 8 bits al voorgealloceerd
            StringBuilder builder = new StringBuilder(8);
            do
            {
                uint rest = decimalNumber % 2;
                decimalNumber /= 2;
                builder.Append(rest);
            } while (decimalNumber != 0);

            // Extra nullen achteraan toevoegen
            int extraZeroes = 8 - (builder.Length % 8);
            extraZeroes %= 8;
            for (int i = 0; i < extraZeroes; i++)
                builder.Append(0);

            // Keer alles om (eerst ook alle nodige bits vooralloceren)
            // Vooralloceren (indien mogelijk) is efficienter!
            StringBuilder binaryBuilder = new StringBuilder(builder.Length);
            for (int i = builder.Length - 1; i >= 0; i--)
                binaryBuilder.Append(builder[i]);

            return binaryBuilder.ToString();
        }

        private string DecimalToBinaryUntil255(uint decimalNumber)
        {
            // Vooralloceren: We zetten de capacity van de StringBuilder op 8
            StringBuilder binaryBuilder = new StringBuilder(8);
            uint divider = 128;
            for (int i = 0; i < binaryBuilder.Capacity; i++)
            {
                uint bit = decimalNumber / divider;
                binaryBuilder.Append(bit);
                decimalNumber %= divider; // dec = dec % deler;
                divider /= 2;
            }

            return binaryBuilder.ToString();
        }

        private void convertUntil255Button_Click(object sender, RoutedEventArgs e)
        {
            uint decimalNumber;
            bool isSucceeded = uint.TryParse(decimalTextBox.Text, out decimalNumber);

            if (!isSucceeded || decimalNumber > 255)
            {
                MessageBox.Show("Geef een getal in van 0 tot 255!", "Foutieve invoer", MessageBoxButton.OK, MessageBoxImage.Error);
                decimalTextBox.SelectAll();
                decimalTextBox.Focus();
            }
            else
            {
                binaryTextBox.Text = DecimalToBinaryUntil255(decimalNumber);
            }
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            uint decimalNumber;
            bool isSucceeded = uint.TryParse(decimalTextBox.Text, out decimalNumber);

            if (!isSucceeded)
            {
                MessageBox.Show("Geef een natuurlijk getal in!", "Foutieve invoer", MessageBoxButton.OK, MessageBoxImage.Error);
                decimalTextBox.SelectAll();
                decimalTextBox.Focus();
            }
            else
            {
                binaryTextBox.Text = DecimalToBinary(decimalNumber);
            }
        }
    }
}
