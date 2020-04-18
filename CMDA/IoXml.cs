using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CMDA
{
    //Common Data Access Class: IoXML to serialize object to XML file
    public class IoXml
    {
        public object loadXml(Type objType, string path)
        {
            return Deserialize(objType, path);
        }
        public void saveXml(object obj, Type objType, string path)
        {
            Serialize(obj, objType, path);
        }

        //Serialization
        private void Serialize(object obj, Type objType, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                //XmlSerializer serializer = new XmlSerializer(objType);
                XmlSerializer serializer = XmlSerializer.FromTypes(new[] { objType })[0];
                serializer.Serialize(fs, obj);
            }
        }
        private static object Deserialize(Type objType, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                //XmlSerializer serializer = new XmlSerializer(objType);
                XmlSerializer serializer = XmlSerializer.FromTypes(new[] { objType })[0];
                return serializer.Deserialize(fs);
            }
        }
    }
}
