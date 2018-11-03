using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion01
{
    public class ProductVariablePrice : Product
    {
        #region Properties
        public string MeasureUnit { get; set; }

        public decimal MeasureUnitPrice { get; set; }

        public float Quantity { get; set; }

        public float TaxRate { get; set; }
        #endregion

        #region Constructors
        public ProductVariablePrice(int productId, string name, string measureUnit, 
            decimal measureUnitPrice, float quantity, float taxRate) : base(productId, name)
        {
            this.MeasureUnit = measureUnit;
            this.MeasureUnitPrice = measureUnitPrice;
            this.Quantity = quantity;
            this.TaxRate = taxRate;
        }
        #endregion

        #region Methods
        public override decimal GetPrice()
        {
            return (this.MeasureUnitPrice * (decimal)this.Quantity) * (1 + (decimal)this.TaxRate);
        }

        public override decimal GetTax()
        {
            return this.MeasureUnitPrice * (decimal)this.Quantity * (decimal)this.TaxRate;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Measure Unit......: {this.MeasureUnit,12}\n\t" +
                $"Quantity..........: {this.Quantity,12:N2}\n\t" +
                $"Tax...............: {this.GetTax(),12:C2}\n\t" +
                $"Value to pay......: {this.GetPrice(),12:C2}";
        }
        #endregion
    }
}