namespace SalesMangmentSystem.BLL.Dtos
{
    public class SaleOrderReadProductDto
    {
        public int SaleOrderID { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double ProductQuantity { get; set; }
        public double ProductTotalPrice { get; set; }
    }
}
