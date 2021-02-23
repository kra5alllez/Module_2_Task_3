using System;

namespace Module_2_Task_3_Vasylchenko
{
    public class Starter
    {
        private readonly Present _present;

        public Starter()
        {
            _present = new Present();
        }

        public void Run()
        {
            var arrey = _present.CreatePresent();
            Console.WriteLine($"Present Weight:" + _present.WeightPresent(arrey));
            Console.WriteLine(_present.WriteArrey(arrey));
            Array.Sort(arrey);
            Console.WriteLine("Sorting sweets by weight:");
            Console.WriteLine(_present.WriteArrey(arrey));
            var arreyCriterias = arrey.Search(TypesOfChokolate.Dark, 15);
            Console.WriteLine("Dark chocolate sweets weighing more than 15:");
            Console.WriteLine(_present.WriteArrey(arreyCriterias));
        }
    }
}
