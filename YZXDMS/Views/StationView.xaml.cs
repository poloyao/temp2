﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
using YZXDMS.Model;

namespace YZXDMS.Views
{
    /// <summary>
    /// Interaction logic for StationView.xaml
    /// </summary>
    public partial class StationView : UserControl
    {
        public StationView()
        {
            InitializeComponent();
            Binding bd = new Binding("Station") { Source = this };
            bd.Mode = BindingMode.TwoWay;
            bd.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            this.grid.SetBinding(Grid.DataContextProperty, bd);
            
        }


        public StationModel Station
        {
            get { return (StationModel)GetValue(StationProperty); }
            set { SetValue(StationProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StationProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StationProperty =
            DependencyProperty.Register("Station", typeof(StationModel), typeof(StationView));
        

        
    }

    public class CarIcoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || value.ToString() == string.Empty)
            { }
            else
            {
                return "/YZXDMS;component/Img/car1.png";
            }
            return null;

        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
        
    }
}
