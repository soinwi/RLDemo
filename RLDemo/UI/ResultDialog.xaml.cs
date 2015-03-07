using System;
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
using System.Windows.Shapes;

namespace RLDemo.UI
{
    /// <summary>
    /// Interaction logic for ResultDialog.xaml
    /// </summary>
    public partial class ResultDialog : Window
    {
        public ResultDialog()
        {
            Discipline = "";
            Result = (decimal)0.0;

            InitializeComponent();

            this.Loaded += ResultDialog_Loaded;
        }

        void ResultDialog_Loaded(object sender, RoutedEventArgs e)
        {
            _disciplineBox.Text = Discipline;
            _resultBox.Text = Result.ToString();
        }

        public string Discipline
        {
            get;
            set;
        }

        public decimal Result
        {
            get;
            set;
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
            decimal result;
            string _discipline = _disciplineBox.Text;

            if (decimal.TryParse(_resultBox.Text, out result))
            {
                Discipline = _discipline;
                Result = result;
                DialogResult = true;
                this.Close();
            }
        }
    }
}
