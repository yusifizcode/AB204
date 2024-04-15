namespace CastingClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Notebook notebook = new Notebook();
            Notebook notebook1 = new Notebook();
            Notebook notebook2 = new Notebook();
            Notebook notebook3 = new Notebook();


            Phone phone = new Phone();
            Phone phone1 = new Phone();
            Phone phone2 = new Phone();
            Phone phone3 = new Phone();

            Store store = new Store();
            store.NotebookLimit = 3;
            store.PhoneLimit = 3;

            store.AddProduct(phone);
            store.AddProduct(phone1);
            store.AddProduct(phone2);
            store.AddProduct(phone3);

            store.AddProduct(notebook);
            store.AddProduct(notebook1);
            store.AddProduct(notebook2);
        }
    }
}