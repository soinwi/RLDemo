using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace RLDemo.BusinessObjects
{
    public class Person: System.ComponentModel.INotifyPropertyChanged
    {
        private DataLayer.People _person;
        

        public Person(DataLayer.People person_)
        {
            
            _person = person_;
        }

        public int Id
        {
            get
            {
                return _person.Id;
            }
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

        public void AddResult(string discipline_, decimal mark_)
        {
            var res = new DataLayer.Result() { 
                People = this._person,
                Discipline = discipline_,
                 Mark = mark_
            };

            _person.Results.Add(res);

            App.Controller.CommitChanges();

            if(PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Results"));
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Name"));
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

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    }
}
