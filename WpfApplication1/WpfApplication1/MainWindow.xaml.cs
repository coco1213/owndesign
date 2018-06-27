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
using System.Windows.Forms;

namespace WpfApplication1
{
    public partial class MainWindow : Window
    {
        Timer timer;
        int sec;
        public MainWindow()
        {
            InitializeComponent();
        }

            //開始倒數
           void timer_Tick(object sender, EventArgs e)
        {
            if (sec > 0)
            {
                timertext.Text = sec + "  seconds";
                sec--;
            }
            else
            {
                timer.Stop();
                timertext.Text = "Time's up!";
                //播放音樂
                MediaPlayer player = new MediaPlayer();

                player.Open(new Uri("BLOW.WAV", UriKind.Relative));

                player.Play();
            }
        }
 




        private void timerbtn_Click(object sender, RoutedEventArgs e)
        {
            //sender判斷進入的按鈕
            if (sender == timerbtn)
            {
                //倒數的秒數
                sec = 30;
                timer = new Timer();
                //設定計時器的速度
                timer.Interval = 1000;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }
        }

        private void timerbtn1_Click(object sender, RoutedEventArgs e)
        {   
            //暫停計時
            timer.Stop();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void timerbtn2_Click(object sender, RoutedEventArgs e)
        {
            //繼續計時
            timer.Start();
        }
    }
}
