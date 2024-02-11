using SchoolBusAppWpf.ViewModels;
using SchoolBusAppWpf.Windows;
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

namespace SchoolBusAppWpf.Views.Pages
{
    /// <summary>
    /// Interaction logic for ClassView.xaml
    /// </summary>
    public partial class ClassView : Page
    {
        public ClassView()
        {
            InitializeComponent();
            DataContext = new ClassViewModel();
        }

   

        private void AddClassClick(object sender, RoutedEventArgs e)
        {
            Window w = new CreateClassWindow();
            w.Show();
        }
    }
}
