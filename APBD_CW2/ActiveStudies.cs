using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace APBD_CW2
{
    public class ActiveStudies
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "numberofstudents")]
        public int NumberOfStudents { get; set; }


    }
}
