using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EmployeesData
{
    public static class SerializeerClass
    {
        public static void SerializeObject(this List<Employee> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Employee>));
            using (var stream = File.OpenWrite(fileName))
            {
                serializer.Serialize(stream, list);
            }
        }
        public static void Deserialize(this List<Employee> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Employee>));
            using (var stream = File.OpenRead(fileName))
            {
                var other = (List<Employee>)(serializer.Deserialize(stream));
                list.Clear();
                list.AddRange(other);
            }
        }
    }
}
