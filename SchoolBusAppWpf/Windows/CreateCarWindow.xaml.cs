﻿using SchoolBusAppWpf.ViewModels.WindowsViewModels;
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
using System.Windows.Shapes;

namespace SchoolBusAppWpf.Windows
{
    /// <summary>
    /// Interaction logic for CreateCarWindow.xaml
    /// </summary>
    public partial class CreateCarWindow : Window
    {
        public CreateCarWindow()
        {
            InitializeComponent();
            DataContext = new CreateCarWindowModel();
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
