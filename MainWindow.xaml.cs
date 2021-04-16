using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using kalum2021.ModelView;//
using MahApps.Metro.Controls;

namespace kalum2021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel modelo=new MainViewModel(); 
            this.DataContext=modelo; 
        }
    }
}