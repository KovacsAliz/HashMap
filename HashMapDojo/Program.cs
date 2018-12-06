using System;

namespace HashMapDojo
{
    class Program
    {
       

        static void Main(string[] args)
        {
            CreateHM createHM = new CreateHM();

            createHM.AddElement("firstElement", 12);
            foreach (var element in createHM.elements)
            {
                foreach (var linkedElement in element)
                {
                    System.Console.WriteLine(linkedElement.Key + linkedElement.Value);
                }
            }
            Console.ReadKey();
        }
    }
}
