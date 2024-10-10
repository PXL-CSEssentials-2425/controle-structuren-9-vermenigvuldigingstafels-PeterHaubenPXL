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
using TestStack.White.UIItems.Scrolling;

namespace VermenigvuldigingsTafels
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri("../../../img/Achtergrond.jpg", UriKind.Relative));
            this.Background = myBrush;
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            string result = "";

            for (int i = 1; i < 13; i++)
            {
                result += "De tafels van vermenigvuldiging\n\n";

                for (int j = 1; j < 13; j++)
                {
                    result += $"{i} X {j} = " + (i * j).ToString() + "\n";
                }

                result += "\n";
            }

            result += "\n";
            resultTextBox.Text = result;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = "";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}