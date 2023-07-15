using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butikunmuhasebe.API
{
    public class jsconfig
    {
        [JsonProperty("connectionstring")]
        public string connectionString { get; private set; }
    }
}
