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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        String filename = "";
        string text = "";
      
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OPENbtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                filename = dlg.FileName;
                TEXXT.Text = System.IO.File.ReadAllText(dlg.FileName);
            }
        }

        private void NEWbtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TEXXT.Text = "";
        }

        private void SAVEbtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
           
        if(filename=="")
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();


            Nullable<bool> resuln = dlg.ShowDialog();
            filename = dlg.FileName;

            System.IO.File.WriteAllText(dlg.FileName, TEXXT.Text);
           
           
        }    
     else 
        {
            System.IO.File.WriteAllText(filename, TEXXT.Text);
           
        }

       }

            

        private void SAVEASbtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();


            Nullable<bool> result = dlg.ShowDialog();


            if (result == true)
            {
                filename = dlg.FileName;

                System.IO.File.WriteAllText(dlg.FileName, TEXXT.Text);
            }
        }

        private void LITTLE_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TEXXT.FontSize = 10;
        }

        private void GOOD_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TEXXT.FontSize = 15;
        }

        private void BIG_MouseDown(object sender, MouseButtonEventArgs e)
        {

            TEXXT.FontSize = 30;
        }
        private void BUTTONN_Click(object sender, RoutedEventArgs e)
        {
            TEXXT.Background = Brushes.Gray;
            TEXXT.Foreground = Brushes.White;
            BUTTONN.Background = Brushes.White;
        }

        private void BUUUTON_Click(object sender, RoutedEventArgs e)
        {
            TEXXT.Background = Brushes.White;
            TEXXT.Foreground = Brushes.Black;
        }
    }
}
