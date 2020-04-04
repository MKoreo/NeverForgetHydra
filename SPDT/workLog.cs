using CMDA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDT
{
    [Serializable]
    public class workLog
    {
        public List<Record> records { get; } = new List<Record>();

        //Others
        private string path = "";
        public workLog()
        {
            
        }

        public void addRecord(DateTime dateTime, string subject, string projectCode, decimal minutes)
        {
            //records.Add(new Record(dateTime, subject, projectCode, minutes));
            foreach (Record rec in records)
            {
                if (rec.date == dateTime && rec.projectCode == projectCode && rec.subject == subject)
                {
                    rec.minutes += minutes;
                    return;
                }
            }
            //Else add
            records.Add(new Record(dateTime, subject, projectCode, minutes));
        }

        public void removeRecord(Record record)
        {
            records.Remove(record);
        }

        public void removeRecord(DateTime dateTime, string projectCode, string subject)
        {
           List<Record> records = getRecords(dateTime);
           foreach(Record rec in records)
            {
                if (rec.projectCode == projectCode && rec.subject == subject)
                {
                    removeRecord(rec);
                }
            }
        }

        public string getPath()
        {
            return path;
        }

        public List<Record> getRecords(DateTime dateTime)
        {
            List<Record> returnList = new List<Record>();
            foreach (Record rec in records)
            {
                if (rec.date == dateTime)
                {
                    returnList.Add(rec);
                } 
            }
            return returnList;
        }

        public void createNew(String path)
        {
            this.path = path;
            save();
        }

        public workLog load(string path)
        {
            this.path = path;
            IoXml xmlReader = new IoXml();
            workLog log = (workLog)(xmlReader.loadXml(GetType(), path));
            log.path = path;
            return log;
        }

        public void save()
        {
            IoXml xmlReader = new IoXml();
            xmlReader.saveXml(this, GetType(), path);
        }
    }
}
