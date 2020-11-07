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

namespace PictureControll
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            ButtonStackPanel.Visibility = Visibility.Collapsed;
            
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            ButtonStackPanel.Visibility = Visibility.Visible;
            this.BorderThickness = new Thickness(5, 5, 5, 5);
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            ButtonStackPanel.Visibility = Visibility.Collapsed;
            this.BorderThickness = new Thickness(0, 0, 0, 0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi");
        }
    }


}
