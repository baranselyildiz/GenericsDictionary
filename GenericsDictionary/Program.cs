using System;

namespace GenericsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string> dictionary = new MyDict<int, string>();

            dictionary.Add(213, "Elma");
            dictionary.Add(112, "Armut");
            dictionary.Add(301, "Kayısı");
            dictionary.Add(130, "Muz");
            dictionary.Add(72, "Karpuz");
            dictionary.Add(620, "Çilek");

            for (int i = 0; i < dictionary.Items1.Length; i++)
            {
                Console.WriteLine("Stok Adedi : " + dictionary.Items1[i] + "  Ürün Adı : " + dictionary.Items2[i]);
            }
        }
    }
}
