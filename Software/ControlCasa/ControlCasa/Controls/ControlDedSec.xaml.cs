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

namespace ControlCasa.Controls
{
    /// <summary>
    /// Interaction logic for ControlDedSec.xaml
    /// </summary>
    public partial class ControlDedSec : UserControl
    {
        public ControlDedSec()
        {
            InitializeComponent();
        }



        private void rectClose_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
