using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppC968.InventoryPartProduct
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part associatedPart)
        {
            if (AssociatedParts == null)
            {
                AssociatedParts = new BindingList<Part>();
            }
            AssociatedParts.Add(associatedPart);
        }
        public bool removeAssociatedPart(int partID)
        {
            foreach (var part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return true;
                }
            }
            return false;
        }

        public Part lookupAssociatedPart(int partID)
        {
            foreach (var part in AssociatedParts)
            {
                if (part.PartID == partID)
                { return part; }
            }
            return null;
            // message "part could not be found"
        }
    }
}
