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

namespace Presentation
{
    public partial class MainWindow : Window
    {
        private ViewModel viewModel = new ViewModel(new Model());
        public MainWindow()
        {
            InitializeComponent();
            Loaded += (s, e) => DataContext = viewModel;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Add_Book_Info_Button(object sender, RoutedEventArgs e)
        {

        }
    }
}