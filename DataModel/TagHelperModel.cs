using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class TagFatherModel
    {
        public string title { get; set; }

        public string id { get; set; }

        public bool spread { get; set; }
        public List<Childen> children { get; set; }

    }

    public class Childen
    {
        public string title { get; set; }

        public string id { get; set; }

        public bool spread { get; set; }
        public List<Childen> children { get; set; }
    }

}
