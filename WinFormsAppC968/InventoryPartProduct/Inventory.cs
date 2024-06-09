using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppC968.InventoryPartProduct
{
    public class Inventory
    {

        private static Random random = new Random();
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

        public Inventory()
        {
            AllParts = new BindingList<Part>
        {
            new InHousePart { PartID = GenerateRandomID(), Name = "Part A", Inventory = 10, PriceCost = 15.50m, Min = 1, Max = 20, MachineID = 1001 },
            new InHousePart { PartID = GenerateRandomID(), Name = "Part B", Inventory = 5, PriceCost = 25.75m, Min = 1, Max = 15, MachineID = 1002 },
            new OutsourcedPart { PartID = GenerateRandomID(), Name = "Part C", Inventory = 20, PriceCost = 5.25m, Min = 5, Max = 30, CompanyName = "Company X" },
            new OutsourcedPart { PartID = GenerateRandomID(), Name = "Part D", Inventory = 7, PriceCost = 45.00m, Min = 1, Max = 10, CompanyName = "Company Y" },
            new InHousePart { PartID = GenerateRandomID(), Name = "Part E", Inventory = 8, PriceCost = 18.50m, Min = 2, Max = 25, MachineID = 1003 },
            new InHousePart { PartID = GenerateRandomID(), Name = "Part F", Inventory = 12, PriceCost = 22.75m, Min = 1, Max = 30, MachineID = 1004 },
            new OutsourcedPart { PartID = GenerateRandomID(), Name = "Part G", Inventory = 18, PriceCost = 35.25m, Min = 3, Max = 40, CompanyName = "Company Z" },
            new OutsourcedPart { PartID = GenerateRandomID(), Name = "Part H", Inventory = 3, PriceCost = 55.00m, Min = 1, Max = 8, CompanyName = "Company W" },
            new InHousePart { PartID = GenerateRandomID(), Name = "Part I", Inventory = 14, PriceCost = 10.00m, Min = 1, Max = 20, MachineID = 1005 },
            new OutsourcedPart { PartID = GenerateRandomID(), Name = "Part J", Inventory = 9, PriceCost = 40.00m, Min = 2, Max = 15, CompanyName = "Company V" }
        };

            Products = new BindingList<Product>
        {
            new Product
            {
                ProductID = GenerateRandomID(),
                Name = "Product 1",
                Price = 19.99m,
                InStock = 50,
                Min = 5,
                Max = 100,
                AssociatedParts = new BindingList<Part> { AllParts[0], AllParts[1] }
            },
            new Product
            {
                ProductID = GenerateRandomID(),
                Name = "Product 2",
                Price = 29.99m,
                InStock = 30,
                Min = 5,
                Max = 80,
                AssociatedParts = new BindingList<Part> { AllParts[2], AllParts[3] }
            },
            new Product
            {
                ProductID = GenerateRandomID(),
                Name = "Product 3",
                Price = 39.99m,
                InStock = 20,
                Min = 5,
                Max = 60,
                AssociatedParts = new BindingList<Part> { AllParts[4], AllParts[5] }
            },
            new Product
            {
                ProductID = GenerateRandomID(),
                Name = "Product 4",
                Price = 49.99m,
                InStock = 40,
                Min = 5,
                Max = 90,
                AssociatedParts = new BindingList<Part> { AllParts[6], AllParts[7] }
            },
            new Product
            {
                ProductID = GenerateRandomID(),
                Name = "Product 5",
                Price = 59.99m,
                InStock = 60,
                Min = 5,
                Max = 110,
                AssociatedParts = new BindingList<Part> { AllParts[8], AllParts[9] }
            },
            new Product
            {
                ProductID = GenerateRandomID(),
                Name = "Product 6",
                Price = 69.99m,
                InStock = 70,
                Min = 5,
                Max = 120,
                AssociatedParts = new BindingList<Part> { AllParts[0], AllParts[2] }
            },
            new Product
            {
                ProductID = GenerateRandomID(),
                Name = "Product 7",
                Price = 79.99m,
                InStock = 80,
                Min = 5,
                Max = 130,
                AssociatedParts = new BindingList<Part> { AllParts[1], AllParts[3] }
            },
            new Product
            {
                ProductID = GenerateRandomID(),
                Name = "Product 8",
                Price = 89.99m,
                InStock = 90,
                Min = 5,
                Max = 140,
                AssociatedParts = new BindingList<Part> { AllParts[4], AllParts[6] }
            },
            new Product
            {
                ProductID = GenerateRandomID(),
                Name = "Product 9",
                Price = 99.99m,
                InStock = 100,
                Min = 5,
                Max = 150,
                AssociatedParts = new BindingList<Part> { AllParts[5], AllParts[7] }
            },
            new Product
            {
                ProductID = GenerateRandomID(),
                Name = "Product 10",
                Price = 109.99m,
                InStock = 110,
                Min = 5,
                Max = 160,
                AssociatedParts = new BindingList<Part> { AllParts[8], AllParts[9] }
            }
        };
        }

        private int GenerateRandomID()
        {
            return random.Next(10000, 99999);
        }

        public void addProduct(Product product)
        {
            if (Products == null)
            {
                Products = new BindingList<Product>();
            }
            Products.Add(product);
        }

        public bool removeProduct(int productID)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products.RemoveAt(i);
                    return true;
                    //write confirmation message that product was removed
                }
            }
            return false;
            //write message product could not be removed
        }
        public Product lookupProduct(int productId)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productId)
                {
                    return product;
                }
            }
            return null;
            //message saying product could not be found
        }

        public void updateProduct(Product updatedProduct, int productID)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = updatedProduct;
                    return;
                }
            }

            throw new ArgumentException("Product with the specified ID not found.");
        }

        public void addPart(Part part)
        {
            if (AllParts == null)
            {
                AllParts = new BindingList<Part>();
            }
            AllParts.Add(part);
        }

        public bool deletePart(Part part)
        {
            if (AllParts.Contains(part))
            {
                AllParts.Remove(part);
                return true;
                //Write confirmation message
            }
            else
            {
                return false;
                //write message saying it could not be deleted
            }
        }
        public Part lookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
            //message saying part could not be found
        }

        public void updatePart(int partID, Part updatedPart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = updatedPart;
                    return;
                }
            }
            throw new ArgumentException("Part with the specified ID not found.");
        }
    }
}
