using System.Text;

namespace Capitulo9_composition2.Entities
{
    class OrderItem
    {
        public int Quantily { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantily, double price, Product product)
        {
            Quantily = quantily;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantily * Price;
        }

        public override string ToString()
        {
           return Product.Name + ", R$" + Product.Price + ", Quantity: " + Quantily + ", Subtotal: R$" + SubTotal().ToString();
        }
    }
}
