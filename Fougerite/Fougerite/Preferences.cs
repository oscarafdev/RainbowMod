using Fougerite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fougerite
{
    class Preferences
    {
        /*Product product = new Product();
product.ExpiryDate = new DateTime(2008, 12, 28);

JsonSerializer serializer = new JsonSerializer();
serializer.Converters.Add(new JavaScriptDateTimeConverter());
serializer.NullValueHandling = NullValueHandling.Ignore;

using (StreamWriter sw = new StreamWriter(@"c:\json.txt"))
using (JsonWriter writer = new JsonTextWriter(sw))
{
    serializer.Serialize(writer, product);
    // {"ExpiryDate":new Date(1230375600000),"Price":0}
}*/
        //Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);
        public static RainbowConfig GetRainbowConfig()
        {

            JsonSerializer serializer = new JsonSerializer();
            RainbowConfig config;
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamReader sw = new StreamReader(Path.Combine("Gamemode\\Config", "Rainbow.json")))
            using (JsonReader reader = new JsonTextReader(sw))
            {
                config = serializer.Deserialize<RainbowConfig>(reader);

            }
            return config;
        }

    }
}
