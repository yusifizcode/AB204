using System.Runtime.Serialization;

namespace Serialization
{
    [Serializable]
    public class Product : ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public string Description { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id, typeof(Product));
            info.AddValue("Name", Name, typeof(Product));
            info.AddValue("Age", Age, typeof(Product));
            info.AddValue("Description", Description, typeof(Product));
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Description}";
        }
    }
}