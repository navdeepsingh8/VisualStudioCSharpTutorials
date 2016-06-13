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

namespace HelloWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region EventHandlers part of the code
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (RadioButton1.IsChecked == true) {
                MessageBox.Show("Hello.");
                RadioButton1.IsChecked = false;
            }
            else if (RadioButton2.IsChecked == true)
            {
                MessageBox.Show("Goodbye.");
                RadioButton2.IsChecked = false;
            }
            else
            {
                MessageBox.Show("You didn't select an option buster.");
            }

            Console.WriteLine("Whoa!");

        }
        #endregion
    }
}
