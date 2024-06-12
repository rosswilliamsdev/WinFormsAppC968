using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppC968.InventoryPartProduct
{
    public class Validator
    {
        public bool ValidateProduct(Product product, out string errorMessage)
        {
            if (string.IsNullOrEmpty(product.Name))
            {
                errorMessage = "Product name is required.";
                return false;
            }

            if (product.InStock < 0)
            {
                errorMessage = "Inventory must be a non-negative number.";
                return false;
            }

            if (product.Price < 0)
            {
                errorMessage = "Price must be a non-negative number.";
                return false;
            }

            if (product.Min > product.Max)
            {
                errorMessage = "Min cannot be greater than Max.";
                return false;
            }

            if (product.InStock < product.Min || product.InStock > product.Max)
            {
                errorMessage = "Inventory must be between Min and Max.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        public bool ValidatePart(Part part, out string errorMessage)
        {
            if (string.IsNullOrEmpty(part.Name))
            {
                errorMessage = "Part name is required.";
                return false;
            }

            if (part.Inventory < 0)
            {
                errorMessage = "Inventory must be a non-negative number.";
                return false;
            }

            if (part.PriceCost < 0)
            {
                errorMessage = "Price must be a non-negative number.";
                return false;
            }

            if (part.Min > part.Max)
            {
                errorMessage = "Min cannot be greater than Max.";
                return false;
            }

            if (part.Inventory < part.Min || part.Inventory > part.Max)
            {
                errorMessage = "Inventory must be between Min and Max.";
                return false;
            }

            errorMessage = null;
            return true;
        }
    }

}
