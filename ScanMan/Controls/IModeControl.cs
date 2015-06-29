using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScanMan
{
    interface IModeControl
    {
        void BarcodeLogic(Barcode barcode);
        void Clear();
        void Print();
    }
}
