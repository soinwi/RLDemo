using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace RLDemo.BusinessObjects
{
    public class Person
    {
        private DataLayer.People _person;
        public Person(DataLayer.People person_)
        {
            _person = person_;
        }

        public string Name
        {
            get
            {
                return _person.Name;
            }
            set
            {
                _person.Name = value;
            }
        }

        public ObservableCollection<Result> Results
        {
            get
            {
                return new ObservableCollection<Result>(_person.Results.Select(n => new Result(n)));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
