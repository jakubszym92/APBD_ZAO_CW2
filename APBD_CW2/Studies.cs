using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace APBD_CW2
{
    public class Studies
    {

        [XmlElement(ElementName = "name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "mode")]
        [JsonPropertyName("mode")]
        public string Mode { get; set; }
    }
}
