#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Windows;


namespace StackedHeaderRowsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //// Uncomment to change height of the Stacked headers
            //this.dataGrid.Loaded += DataGrid_Loaded;
            //this.dataGrid.QueryRowHeight += DataGrid_QueryRowHeight;
        }

        private void DataGrid_QueryRowHeight(object sender, Syncfusion.UI.Xaml.Grid.QueryRowHeightEventArgs e)
        {
            if (e.RowIndex < this.dataGrid.GetHeaderIndex())
            {
                e.Height = 50;
                e.Handled = true;
            }
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var visualContainer = dataGrid.GetVisualContainer();
            int count = dataGrid.StackedHeaderRows.Count;

            for (int i = 0; i < count; i++)
            {
                visualContainer.RowHeights[i] = 50;
            }

            visualContainer.InvalidateMeasure();
        }
    }
}
