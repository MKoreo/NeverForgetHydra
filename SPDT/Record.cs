using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDT
{
    [Serializable]
    public class Record
    {
        //DataType class
        public DateTime date { get; set; }
        public string projectCode { get; set; }
        public string subject { get; set;  }
        public decimal minutes { get; set; }

        public Record()
        {

        }
        public Record(DateTime dateTime, string subject, string projectCode, decimal minutes)
        {
            this.date = dateTime;
            this.projectCode = projectCode;
            this.subject = subject;
            this.minutes = minutes;
        }
    }
}
