using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLDemo.BusinessObjects
{
    public class Result
    {
        private DataLayer.Result _result;

        public Result(DataLayer.Result result_)
        {
            _result = result_;
        }

        public string Discipline
        {
            get
            {
                return _result.Discipline;
            }
            set
            {
                _result.Discipline = value;
            }
        }

        public decimal Mark
        {
            get
            {
                return (_result.Mark??(decimal)0.0);
            }
            set
            {
                _result.Mark = value;
            }
        }


        public override string ToString()
        {
            return Discipline + ": " + Mark;
        }
    }
}
