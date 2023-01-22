
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace APBD_CW2
{
    public class Student
    {
        [XmlElement(ElementName = "indexNumber")]
        [JsonPropertyName("indexNumber")]
        public string Id { get; set; }

        [XmlElement(ElementName = "fname")]
        [JsonPropertyName("fname")]
        public string Name { get; set; }

        [XmlElement(ElementName = "lname")]
        [JsonPropertyName("lname")]
        public string LastName { get; set; }

        [XmlElement(ElementName = "birthdate")]
        [JsonPropertyName("birthdate")]
        public string BirthDate { get; set; }

        [XmlElement(ElementName = "email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "studies")]
        [JsonPropertyName("studies")]
        public Studies Studies { get; set; }

        [XmlElement(ElementName = "mothersName")]
        [JsonPropertyName("mothersName")]
        public string MothersName { get; set; }

        [XmlElement(ElementName = "fathersName")]
        [JsonPropertyName("fathersName")]
        public string FathersName { get; set; }



    }
}
