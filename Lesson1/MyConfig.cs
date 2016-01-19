using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Lesson1
{
    public class MyConfig : ConfigurationSection
    {
        [ConfigurationProperty("param1")]
        public string param1
        {
            get { return (string)base["param1"]; }
            set { base["param1"] = value; }
        }
        [ConfigurationProperty("param2")]
        public string param2
        {
            get { return (string)base["param2"]; }
            set { base["param2"] = value; }
        }
        [ConfigurationProperty("param3")]
        public string param3
        {
            get { return (string)base["param3"]; }
            set { base["param3"] = value; }
        }
    }
}