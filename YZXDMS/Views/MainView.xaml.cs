﻿using DevExpress.Xpf.WindowsUI;
using System;
using System.Collections.Generic;
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

namespace YZXDMS.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void OnDocumentFrameNavigating(object sender, DevExpress.Xpf.WindowsUI.Navigation.NavigatingEventArgs e)
        {
            if (e.Cancel) return;
            NavigationFrame frame = (NavigationFrame)sender;
            FrameworkElement oldContent = (FrameworkElement)frame.Content;
            if (oldContent != null)
            {
                //RibbonMergingHelper.SetMergeWith(oldContent, null);
                //RibbonMergingHelper.SetMergeStatusBarWith(oldContent, null);s
            }
        }

        private void OnDocumentFrameNavigated(object sender, DevExpress.Xpf.WindowsUI.Navigation.NavigationEventArgs e)
        {
            FrameworkElement newContent = (FrameworkElement)e.Content;
            if (newContent != null)
            {
                //RibbonMergingHelper.SetMergeWith(newContent, ribbon);
                // RibbonMergingHelper.SetMergeStatusBarWith(newContent, statusBar);
            }
        }
    }
}
