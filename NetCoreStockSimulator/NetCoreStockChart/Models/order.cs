namespace NetCoreStockChart.Models
{
    public class order
    {
        public int Id { get; set; }
        public string User_Id { get; set; }

        public string StockName { get; set; }

        public decimal currentprice { get; set; }

        public decimal quantity { get; set; }

        public double paidamount { get; set; }

    }
}
