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

namespace TestPictureAndUserControlls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var projects = GetProjects();

            if (projects.Count > 0)
            {
                ProjectsViewListPage.ItemsSource = projects;
            }
        }

        private List<Project> GetProjects()
        {
            return new List<Project>()
            {
                new Project("Maks 1", "1"),
                new Project("Maks 2", "2"),
                new Project("Maks 3", "3"),
                new Project("Maks 4", "4"),
                new Project("Maks 5", "5"),
                new Project("Maks 6", "6"),
                new Project("Maks 7", "7"),
                new Project("Maks 8", "8"),
                new Project("Maks 9", "9"),
                new Project("Maks 10", "10"),
                new Project("Maks 11", "11"),
                new Project("Maks 12", "12"),
                new Project("Maks 13", "13"),
                new Project("Maks 14", "14"),
                new Project("Maks 15", "15"),
                new Project("Maks 16", "16")
            };
        }

        public List<Project> CreateProject()
        {
            return new List<Project>()
            {
                new Project("Maks 1", "1")
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi");
            if (sender is Button)
            {
                Button button = sender as Button;
                Project project = button.DataContext as Project;
            }
            ProjectsViewListPage.ItemsSource = CreateProject();
        }
    }
}
