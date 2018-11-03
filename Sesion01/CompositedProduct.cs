using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion01
{
    public class CompositedProduct : Product
    {
        #region Properties
        public List<Product> Products { get; set; }
        #endregion

        #region Constructors
        public CompositedProduct(int productId, string name, List<Product> products) : base(productId, name)
        {
            this.Products = products;
        }
        #endregion

        #region Methods
        public override decimal GetPrice()
        {
            decimal total = 0;
            foreach (var product in this.Products)
            {
                total += product.GetPrice();
            }

            return total;
        }

        public override decimal GetTax()
        {
            decimal total = 0;
            foreach (var product in this.Products)
            {
                total += product.GetTax();
            }

            return total;
        }

        public override string ToString()
        {
            var products = string.Empty;
            foreach (var product in this.Products)
            {
                products += $"{product.Name}, ";
            }

            return $"{base.ToString()}\n\t" +
                $"Products..........: {products}\n\t" +
                $"Tax...............: {this.GetTax(),12:C2}\n\t" +
                $"Value to pay......: {this.GetPrice(),12:C2}";
        }
        #endregion
    }
}
