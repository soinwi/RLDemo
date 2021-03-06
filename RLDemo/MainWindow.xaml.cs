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

namespace RLDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = App.Controller;

            this.Closing += MainWindow_Closing;
        }

        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.Controller.CommitChanges();
        }

        private void results_click(object sender, RoutedEventArgs e)
        {
            var selectedPerson = _peopleBox.SelectedItem;

            if(selectedPerson != null && typeof(BusinessObjects.Person).IsAssignableFrom(selectedPerson.GetType()))
            {
                UI.PersonDetails pd = new UI.PersonDetails((BusinessObjects.Person)selectedPerson);
                pd.ShowDialog();
            }
        }
    }
}
