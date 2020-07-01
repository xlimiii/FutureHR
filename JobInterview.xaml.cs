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

namespace FutureHR
{
    /// <summary>
    /// Logika interakcji dla klasy JobInterview.xaml
    /// </summary>
    public partial class JobInterview : UserControl
    {
        private IJobInterviewInteractions irkObject;
        private string IconName;
       
       
      
        public JobInterview(IJobInterviewInteractions irk)
        {
            InitializeComponent();
            this.irkObject = irk;
            if (irk is Person p)
            {
                IconName = "human.png";
            }
            else
            {
                IconName = "robot.png";
            }
            Image img = new Image
            {
                Height = 130,
                Width = 140,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Source = new BitmapImage(new Uri($@"\Images\{IconName}", UriKind.Relative))
            };
           
            Image imgarrow = new Image
            {
                Source = new BitmapImage(new Uri($@"\Images\arrow.png", UriKind.Relative)),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center             
        };
            Image imghome = new Image
            {
                Source = new BitmapImage(new Uri($@"\Images\home.png", UriKind.Relative)),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center
            };
            powrot.Children.Add(imgarrow);
            ikona.Children.Add(img);
            home.Children.Add(imghome);
        }
        private void HelloClicked(object sender, RoutedEventArgs e)
        {
            odpowiedzi.Text=irkObject.PrzywitajSie();
        }
        private void NameClicked(object sender, RoutedEventArgs e)
        {
            odpowiedzi.Text = irkObject.PodajImieINazwisko();
        }
        private void AgeClicked(object sender, RoutedEventArgs e)
        {
            odpowiedzi.Text = irkObject.PowiedzIleMaszLat();
        }
        private void FeaturesClicked(object sender, RoutedEventArgs e)
        {
            odpowiedzi.Text = irkObject.PowiedzOMocnychStronach();
        }
        private void ReturnClicked(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.RemoveAt((window as MainWindow).GridPrincipal.Children.Count - 1);
        }
        private void HomeClicked(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).GridPrincipal.Children.Add(new Home());
                }
        }







    }
}
