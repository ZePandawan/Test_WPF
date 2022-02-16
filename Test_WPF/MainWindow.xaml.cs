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

namespace Test_WPF
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

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
            openFileDialog1.Filter = "Images (.jpeg)(.jpg)|*.jpg|Images (.png)|*.png";
            openFileDialog1.Title = "Ouvrir une nouvelle photo";
            openFileDialog1.DefaultExt = ".jpg";

            if (openFileDialog1.ShowDialog() == true){
                var test = openFileDialog1.FileName;
                TestLabel.Content = test;
            }
            
            /*
            if(testImage.Source != null)
            {
                testImage.Source = null;
            }
            else
            {
                testImage.Source = "/Capture.jpg";
            }*/

        }
    }
}
