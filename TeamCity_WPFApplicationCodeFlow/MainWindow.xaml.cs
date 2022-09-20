using LiteDB;
using System;
using System.CodeDom;
using System.Linq;
using System.Windows;

namespace TeamCity_WPFApplicationCodeFlow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel = new ViewModel();
        Guid guid1Value = Guid.NewGuid();
        Guid guid2Value = Guid.NewGuid();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_insertion1_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Insert(new Model()
            {
                GuidID = guid1Value,
                FieldName1 = "CTL001",
                FieldName2 = "Soham Pal",
            });

            refreshSource();
        }

        private void refreshSource()
        {
            dg_sourceData.ItemsSource = viewModel.GetAllData();
        }

        private void btn_insertion2_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Insert(new Model()
            {
                GuidID = guid2Value,
                FieldName1 = "CTL002",
                FieldName2 = "Someone Else",
            });
            refreshSource();
        }

        private void btn_updation1_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Update(new Model()
            {
                GuidID = guid1Value,
                FieldName1 = "CTL003",
                FieldName2 = "Soham Pal",
            });
            refreshSource();
        }

        private void btn_deletion1_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Delete(new Model()
            {
                GuidID = guid1Value,
                FieldName1 = "CTL003",
                FieldName2 = "Soham Pal",
            });
            refreshSource();
        }
    }
}
