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
        public int logVersion { get; set; }    // new
        public DateTime addDate { get; set; }   // New
        public DateTime recordDate { get; set; }    // Changed
        public string costCenter { get; set; }  // new
        public string project { get; set; } // Changed
        public string subject { get; set; }
        public decimal minutes { get; set; }

        public Record()
        {

        }
        public Record(DateTime recordDate,string costCenter, string project, string subject , decimal minutes)
        {
            logVersion = 1;
            this.addDate = DateTime.Now;
            this.recordDate = recordDate;

            this.costCenter = costCenter;
            this.project = project;
            this.subject = subject;
            this.minutes = minutes;
        }
    }
}
