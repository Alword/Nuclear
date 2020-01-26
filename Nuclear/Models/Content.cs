using System;
using System.Collections.Generic;
using System.Text;

namespace Almanac.Models
{
    public class Content
    {
        public string Name { get; set; }
        public short LoadedPercentage { get; set; }
        public bool IsLoaded { get => LoadedPercentage == 100; }
    }
}
