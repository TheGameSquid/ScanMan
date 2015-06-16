using System;
using System.Configuration;

namespace ScanMan.Config
{
    public class BarcodeTypeConfigurationCollection : ConfigurationElementCollection
    {
        public BarcodeTypeConfigurationCollection()
        {
            // Empty!!! :)
        }

        public BarcodeTypeConfiguration this[int index]
        {
            get { return (BarcodeTypeConfiguration)BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public void Add(BarcodeTypeConfiguration barcodeTypeConfiguration)
        {
            BaseAdd(barcodeTypeConfiguration);
        }

        public void Clear()
        {
            BaseClear();
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new BarcodeTypeConfiguration();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((BarcodeTypeConfiguration)element).Name;
        }

        public void Remove(BarcodeTypeConfiguration barcodeTypeConfiguration)
        {
            BaseRemove(barcodeTypeConfiguration.Name);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Remove(string name)
        {
            BaseRemove(name);
        }
    }
}
