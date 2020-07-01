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
    /// Logika interakcji dla klasy AllCandidates.xaml
    /// </summary>
    public partial class AllCandidates : UserControl
    {
        List<Person> HumanCandidates = Data.HumanCandidates;
        List<Robot> RobotCandidates = Data.RobotCandidates;
        List<RobotForInterviewAdapter> RobotForInterviewAdapters = Data.RobotAdapters;
        public AllCandidates()
        {
            InitializeComponent();
            human_list.ItemsSource = HumanCandidates;
            robot_list.ItemsSource = RobotCandidates;
            Image imghome = new Image
            {
                Source = new BitmapImage(new Uri($@"\Images\home.png", UriKind.Relative)),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center
            };
            home.Children.Add(imghome);

        }
        private void CandidateClicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            
            if (human_list.SelectedIndex > -1)
            {
                int selInd = human_list.SelectedIndex;
                Person clickedPerson = Data.HumanCandidates[selInd];
                foreach (Window window in Application.Current.Windows)
                    if (window.GetType() == typeof(MainWindow))
                    {

                        (window as MainWindow).GridPrincipal.Children.Add(new JobInterview(clickedPerson));
                    }
            }
            else if (robot_list.SelectedIndex > -1)
            {
                int selInd = robot_list.SelectedIndex;
                RobotForInterviewAdapter clickedRobot = Data.RobotAdapters[selInd];
                foreach (Window window in Application.Current.Windows)
                    if (window.GetType() == typeof(MainWindow))
                        (window as MainWindow).GridPrincipal.Children.Add(new JobInterview(clickedRobot));
            }
            else
            {
                MessageBox.Show("Wybierz kandydata!");
            }
            
           
        }
        private void HomeClicked(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).GridPrincipal.Children.Add(new Home());
                }
        }
        private void RobotSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (robot_list.SelectedIndex > -1)
            {
                human_list.SelectedIndex = -1;
            }

        }
        private void HumanSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (human_list.SelectedIndex > -1)
            {
                robot_list.SelectedIndex = -1;
            }
        }
    }
}
