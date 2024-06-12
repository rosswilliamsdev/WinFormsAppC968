using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppC968.InventoryPartProduct
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal PriceCost { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class InHousePart : Part
    {
        public int MachineID { get; set; }
    }

    public class OutsourcedPart : Part
    {
        public string CompanyName { get; set; }
    }
}
