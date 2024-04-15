namespace CastingClassTask
{
    public class Product
    {
        private static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercent { get; set; }


        public Product()
        {
            _no++;
            No = _no;
        }
    }
}
