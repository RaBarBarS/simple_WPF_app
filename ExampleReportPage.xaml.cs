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

namespace WpfExample
{
    /// <summary>
    /// Logika interakcji dla klasy ExampleReportPage.xaml
    /// </summary>
    public partial class ExampleReportPage : Page
    {
        public ExampleReportPage()
        {
            InitializeComponent();
        }
        // Custom constructor
        public ExampleReportPage(object data) : this()
        {
            // Bind to expense report data.
            this.DataContext = data;
        }
    }
}
