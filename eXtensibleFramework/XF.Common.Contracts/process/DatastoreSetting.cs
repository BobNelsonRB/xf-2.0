﻿
namespace XF.Quality
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [Serializable]
    public class DatastoreSetting
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("key")]
        public string DatastoreConfigKey { get; set; }
    }
}
