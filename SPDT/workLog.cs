using CMDA;
using Newtonsoft.Json;
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
        //XML
        public List<Record> records { get; } = new List<Record>();
        //Others
        private string path = "";
        public workLog(){}

        // ---- Do something with records ----
        public void addRecord(DateTime recordDate, string costCenter, string project, string subject, decimal minutes)
        {
            //records.Add(new Record(dateTime, subject, projectCode, minutes));
            foreach (Record rec in records)
            {
                if (rec.costCenter == costCenter && rec.recordDate == recordDate && rec.project == project && rec.subject == subject)
                {
                    rec.minutes += minutes;
                    return;
                }
            }
            //Else add
            records.Add(new Record(recordDate, costCenter, project, subject, minutes));
        }
        public void removeRecord(Record record)
        {
            records.Remove(record);
        }
        public void removeRecord(DateTime dateTime,string costCenter, string projectCode, string subject)
        {
           List<Record> records = getRecordsByDate(dateTime);
           foreach(Record rec in records)
            {
                if (rec.costCenter == costCenter && rec.project == projectCode && rec.subject == subject )
                {
                    removeRecord(rec);
                }
            }
        }

        // ----- Getters
        public string getPath()
        {
            return path;
        }
        public List<Record> getRecordsByDate(DateTime dateTime)
        {
            List<Record> returnList = new List<Record>();
            foreach (Record rec in records)
            {
                if (rec.recordDate == dateTime)
                {
                    returnList.Add(rec);
                } 
            }
            return returnList;
        }
        public List<Record> getRecordsBetweenDates(DateTime start, DateTime end, bool filterProject)
        {
            List<Record> returnList = new List<Record>();
            int daysBetween = (int)Math.Round((end - start).TotalDays, 0, MidpointRounding.AwayFromZero); // Possibly do +1 to account for missing decimals
            do
            {
                // Append records for every day
                returnList.AddRange(getRecordsByDate(end.AddDays(-daysBetween)));
                daysBetween--;
            } while (daysBetween != -1);

            List<Record> dummy = new List<Record>();
            bool matched = false;
            if (!filterProject)
            {
                foreach (Record rec in returnList)
                {
                    foreach (Record dum in dummy)
                    {
                        if (dum.project == rec.project && dum.subject == rec.subject)
                        {
                            dum.minutes += rec.minutes;
                            matched = true;
                            break;
                        }
                    }
                    if (!matched)
                    {
                        // Json convert, so we pass a copy instead of the real
                        dummy.Add(JsonConvert.DeserializeObject<Record>(JsonConvert.SerializeObject(rec)));
                    }
                    matched = false;
                }
            } else
            {
                foreach (Record rec in returnList)
                {
                    foreach (Record dum in dummy)
                    {
                        if (dum.project == rec.project)
                        {
                            dum.minutes += rec.minutes;
                            matched = true;
                            break;
                        }
                    }
                    if (!matched)
                    {
                        dummy.Add(JsonConvert.DeserializeObject<Record>(JsonConvert.SerializeObject(rec)));
                    }
                    matched = false;
                }
            }

            return dummy;
        }
        // ------ To/From XML
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
