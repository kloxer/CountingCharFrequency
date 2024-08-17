using System.Collections;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CountingStringLength
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


        private void btnAction_Click(object sender, RoutedEventArgs e)
        {
            txtBoxOutput.Clear();
            string userInput1 = txtBoxUserInput.Text;

            if (userInput1.Equals("") || userInput1.Equals(" "))
            {
                MessageBox.Show("Please enter some text");
                txtBoxUserInput.Focus();
            }
            else { 
            int length = userInput1.Length;

            SortedDictionary<char, int> letterCount = new SortedDictionary<char, int>();

            for (int i = 0; i < length; i++)
            {
                char l = userInput1[i];

                if (letterCount.ContainsKey(l))
                {


                    letterCount[l]++;

                }
                else
                {
                    letterCount.Add(l, 1);
                }

            }

            foreach (KeyValuePair<char, int> pair in letterCount)

            {
                if (pair.Key.ToString().Equals(" "))
                {
                    txtBoxOutput.Text += $"Whitespace - {pair.Value} \n";

                }
                else
                { 
                txtBoxOutput.Text+= $"{pair.Key.ToString().ToUpper()} - {pair.Value} \n";
                        }

            }
                // A - 1 
                /*            for (int i = 0; i < letterCount.Count; i++) {
                                txtBoxOutput.Text =   letterCount['A'].ToString() ;

                            }*/
            }
        }
    }
}