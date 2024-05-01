using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product();
            //product.Id = 1;
            //product.Name = "Test";
            //product.Description = "Test";
            //product.Age = 12;
            //ProductToXML(product);


            //ProductToBinary(product);

            //Product product = BinaryToProduct();
            Product product = XMLToProduct();
            Console.WriteLine(product);
        }

        public static void ProductToBinary(Product product)
        {
            string path = "C:\\Users\\User\\Desktop\\data.dat";

            Stream stream = new FileStream(path, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            binaryFormatter.Serialize(stream, product);
        }

        public static Product BinaryToProduct()
        {
            string path = "C:\\Users\\User\\Desktop\\data.dat";

            using Stream stream = new FileStream(path, FileMode.Open);
            //FileStream fs = File.OpenRead(path);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            object binary = binaryFormatter.Deserialize(stream);
            return (Product)binary;
        }

        public static void ProductToXML(Product product)
        {
            string path = "C:\\Users\\User\\Desktop\\data.xml";
            Stream stream = new FileStream(path, FileMode.Create);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
            xmlSerializer.Serialize(stream, product);
        }

        public static Product XMLToProduct()
        {
            string path = "C:\\Users\\User\\Desktop\\data.xml";
            Stream stream = new FileStream(path, FileMode.Open);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
            Product product = (Product)xmlSerializer.Deserialize(stream);

            return product;
        }
    }
}