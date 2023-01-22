
using System.Collections.Generic;

using System.Text.Json.Serialization;

using System.Xml.Serialization;

namespace APBD_CW2
{
    public class University
    {

        public List<Student> studentsAll;
        public List<ActiveStudies> activeStudies;


        [XmlAttribute(AttributeName = "Author")]
        [JsonPropertyName("Author")]
        public string Author { get; set; }

        [XmlAttribute(AttributeName = "CreatedAt")]
        [JsonPropertyName("CreatedAt")]
        public string CreateDate { get; set; }

        public University()
        {
            studentsAll = new List<Student>();
            activeStudies = new List<ActiveStudies>();

        }


        public ActiveStudies getActive(ActiveStudies element)
        {
            if (activeStudies.Contains(element))
            {
                foreach (ActiveStudies activ in activeStudies)
                {
                    if (element.Equals(activ))
                        return activ;
                }
            }

            return null;
        }


    }
}
