using System;
using System.Configuration;

namespace ScanMan.Config
{
    public class BarcodeTypeConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("BarcodeTypes", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(BarcodeTypeConfigurationCollection),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public BarcodeTypeConfigurationCollection BarcodeTypes
        {
            get
            {
                return (BarcodeTypeConfigurationCollection)base["BarcodeTypes"];
            }
        }
    }
}
