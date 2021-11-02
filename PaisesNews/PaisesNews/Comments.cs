using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PaisesNews
{
    public class Comments
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("capital")]
        public string capital { get; set; }


        [JsonPropertyName("population")]
        public int population { get; set; }
    }
}
