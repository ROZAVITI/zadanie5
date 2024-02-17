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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rpm_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void runningButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            double newX = random.Next(Convert.ToInt32(sss.ActualHeight-runningButton.ActualHeight));
            double newY = random.Next(Convert.ToInt32(sss.ActualWidth - runningButton.ActualWidth));
            DoubleAnimation button = new DoubleAnimation(Canvas.GetLeft(runningButton),newY,new Duration(TimeSpan.FromSeconds(2)));
            DoubleAnimation button1 = new DoubleAnimation(Canvas.GetTop(runningButton), newX, new Duration(TimeSpan.FromSeconds(2)));
            runningButton.BeginAnimation(Canvas.LeftProperty, button);
            runningButton.BeginAnimation(Canvas.TopProperty, button1);
        }
    } }
