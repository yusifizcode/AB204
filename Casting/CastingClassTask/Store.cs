namespace CastingClassTask
{
    public class Store
    {
        Phone[] _phones = { };
        Product[] _products = { };
        Notebook[] _notebooks = { };

        public int PhoneLimit { get; set; }
        public int NotebookLimit { get; set; }

        public void AddProduct(Product product)
        {
            if (product is Notebook)
            {
                if (_notebooks.Length < NotebookLimit)
                {
                    Array.Resize(ref _notebooks, _notebooks.Length + 1);
                    _notebooks[_notebooks.Length - 1] = (Notebook)product;
                    Array.Resize(ref _products, _products.Length + 1);
                    _products[_products.Length - 1] = product;
                }
                else
                {
                    Console.WriteLine("notebook limit ashilib");
                }
            }


            if (product is Phone)
            {
                if (_phones.Length < PhoneLimit)
                {
                    Array.Resize(ref _phones, _phones.Length + 1);
                    _phones[_phones.Length - 1] = (Phone)product;
                    Array.Resize(ref _products, _products.Length + 1);
                    _products[_products.Length - 1] = product;
                }
                else
                {
                    Console.WriteLine("phone limit ashilib");
                }
            }


        }
    }
}
