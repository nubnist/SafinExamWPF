﻿using System;
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

namespace SafinExamWPF.Views
{
    /// <summary>
    /// Логика взаимодействия для ListView.xaml
    /// </summary>
    public partial class ListItemsView : Page
    {
        public ListItemsView()
        {
            InitializeComponent();
        }

        private void ButtonCloseFilter_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseFilter.Visibility = Visibility.Collapsed;
            ButtonOpenFilter.Visibility = Visibility.Visible;
        }

        private void ButtonOpenFilter_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenFilter.Visibility = Visibility.Collapsed;
            ButtonCloseFilter.Visibility = Visibility.Visible;
        }
    }
}
