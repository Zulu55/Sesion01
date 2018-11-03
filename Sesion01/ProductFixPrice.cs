namespace Sesion01
{
    public class ProductFixPrice : Product
    {
        #region Properties
        public decimal Price { get; set; }

        public float TaxRate { get; set; }
        #endregion

        #region Constructors
        public ProductFixPrice(int productId, string name, decimal price, float taxRate) : base(productId, name)
        {
            this.Price = price;
            this.TaxRate = taxRate;
        }
        #endregion

        #region Methods
        public override decimal GetPrice()
        {
            return this.Price * (1 + (decimal)this.TaxRate);
        }

        public override decimal GetTax()
        {
            return this.Price * (decimal)this.TaxRate;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Tax...............: {this.GetTax(),12:C2}\n\t" +
                $"Value to pay......: {this.GetPrice(),12:C2}";
        }
        #endregion
    }
}
