using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScanMan
{
    interface IModeControl
    {
        void BarcodeLogic(string barcode);
        void Clear();
        void Print();
    }
}
