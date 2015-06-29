using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text.RegularExpressions;
using ScanMan.Config;

namespace ScanMan
{
    public enum BarcodeType
    {
        AssetAD,
        AssetNonAD,
        Command
    }

    public class Barcode
    {
        private string name;
        private BarcodeType type;
        private string value;

        public string Name 
        {
            get { return this.name; }
        }

        public BarcodeType Type
        {
            get { return this.type; }
        }

        public string Value
        {
            get { return this.value; }
        }

        public Barcode(string barcodeString)
        {
            BarcodeTypeConfigurationSection barcodeConfigSection = ConfigurationManager.GetSection("BarcodeTypeSection") as BarcodeTypeConfigurationSection;
            
            foreach (BarcodeTypeConfiguration barcodeConfig in barcodeConfigSection.BarcodeTypes)
            {
                if (Regex.IsMatch(barcodeString, barcodeConfig.Regex))
                {
                    this.name = barcodeConfig.Name;
                    this.type = (BarcodeType) Enum.Parse( typeof(BarcodeType), barcodeConfig.BarcodeType, true );
                    this.value = barcodeString;
                    break;
                }
            }
        }
    }



}
