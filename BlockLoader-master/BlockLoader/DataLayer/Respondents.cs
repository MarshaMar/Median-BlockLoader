using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlockLoader.DataLayer
{
    public class Respondent
    {
        public string Id { get; set; }
        public List<string> ReachedBlocks { get; set; }
    }
}