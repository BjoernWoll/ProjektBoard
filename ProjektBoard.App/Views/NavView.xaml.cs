﻿using ProjektBoard.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjektBoard.App.Views
{
    /// <summary>
    /// Interaktionslogik für NavView.xaml
    /// </summary>
    public partial class NavView : UserControl
    {
        private NavViewViewModel model;
        public NavView()
        {
            InitializeComponent();
            model = new NavViewViewModel();
            DataContext = model;
        }
    }
}
