namespace CSharpIndexer
{
    internal class CustomIntArray
    {
        public int[] Arr;

        public CustomIntArray()
        {
            Arr = new int[] { };
        }

        public int this[int index] //indexer
        {
            get { return Arr[index]; }
            set { Arr[index] = value; }
        }


        public void Add(int num)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = num;
        }

        public void Remove(int num)
        {
            int[] newArr = { };
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] != num)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = Arr[i];
                }
            }

            Arr = newArr;
        }
    }
}
