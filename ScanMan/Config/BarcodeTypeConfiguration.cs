using System;
using System.Configuration;

namespace ScanMan.Config
{
    public class BarcodeTypeConfiguration : ConfigurationElement
    {
        public BarcodeTypeConfiguration()
        { 
        
        }

        public BarcodeTypeConfiguration(string name, string type, string regex)
        {
            Name = name;
            BarcodeType = type;
            Regex = regex;
        }

        [ConfigurationProperty("Name", DefaultValue = "", IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return (string)this["Name"]; }
            set { this["Name"] = value; }
        }

        [ConfigurationProperty("BarcodeType", DefaultValue = "", IsRequired = true, IsKey = true)]
        public string BarcodeType
        {
            get { return (string)this["BarcodeType"]; }
            set { this["BarcodeType"] = value; }
        }

        [ConfigurationProperty("Regex", DefaultValue = "", IsRequired = true, IsKey = true)]
        public string Regex
        {
            get { return (string)this["Regex"]; }
            set { this["Regex"] = value; }
        }
    }
}
