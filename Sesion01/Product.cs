namespace Sesion01
{
    public abstract class Product
    {
        #region Properties
        public int ProductId { get; set; }

        public string Name { get; set; }
        #endregion

        #region Constructors
        public Product(int productId, string name)
        {
            this.ProductId = productId;
            this.Name = name;
        }
        #endregion

        #region Methods
        public abstract decimal GetPrice();

        public abstract decimal GetTax();

        public override string ToString()
        {
            return $"{this.ProductId,6} {this.Name}";
        }
        #endregion
    }
}
