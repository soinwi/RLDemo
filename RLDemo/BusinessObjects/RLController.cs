using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace RLDemo.BusinessObjects
{
    public class RLController
    {
        private DataLayer.RLDBDataContext _dbContext;

        public RLController(DataLayer.RLDBDataContext dbContext_)
        {
            _dbContext = dbContext_;
        }

        public ObservableCollection<Person> People
        {
            get
            {
                return new ObservableCollection<Person>(_dbContext.Peoples.Select(n => new Person(n)));
            }
        }
    }
}
