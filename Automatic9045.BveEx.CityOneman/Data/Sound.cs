﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Automatic9045.BveEx.CityOneman.Data
{
    [XmlRoot]
    public class Sound
    {
        [XmlAttribute]
        public string Path = null;
    }
}
