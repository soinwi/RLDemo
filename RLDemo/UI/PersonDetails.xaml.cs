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
    /// Interaction logic for PersonDetails.xaml
    /// </summary>
    public partial class PersonDetails : Window
    {


        public PersonDetails(BusinessObjects.Person person_)
        {
            Person = person_;
            InitializeComponent();
        }

        public static readonly DependencyProperty PersonProperty = DependencyProperty.Register(
            "Person",
            typeof(BusinessObjects.Person),
            typeof(PersonDetails)
            );
        public BusinessObjects.Person Person
        {
            get
            {
                return (BusinessObjects.Person)GetValue(PersonProperty);
            }
            set
            {
                SetValue(PersonProperty, value);
            }
        }

        private void addresult_click(object sender, RoutedEventArgs e)
        {
            ResultDialog rd = new ResultDialog();
            if(rd.ShowDialog() != false)
            {
                Person.AddResult(rd.Discipline, rd.Result);
            }
        }


    }
}
