using System;
using System.Text;
using Module_2_Task_3_Vasylchenko.Chokolad;
using Module_2_Task_3_Vasylchenko.Сaramel;

namespace Module_2_Task_3_Vasylchenko
{
    public class Present
    {
        private readonly Random _random;
        private readonly int _numberOfSweets = 15;
        private readonly Sweetnes[] _sweets;
        public Present()
        {
            _random = new Random();
            _sweets = new Sweetnes[_numberOfSweets];
        }

        public Sweetnes[] CreatePresent()
        {
            for (var i = 0; i < _numberOfSweets; i++)
            {
                var randomSweets = _random.Next(0, 2);
                var randomPrice = _random.Next(10, 100);
                var randomWeight = _random.Next(10, 50);
                if (randomSweets == 0)
                {
                    var randomTypesOfChokolate = _random.Next(0, 3);
                    var randomTypeChokolat = _random.Next(0, 30);
                    var randomTypeFilling = _random.Next(0, 3);
                    var randomTypePovered = _random.Next(0, 2);
                    _sweets[i] = new PowderForChokolate($"Chocolate:{i}", randomPrice, randomWeight, (TypesOfChokolate)randomTypesOfChokolate, randomTypeChokolat, (TypeFilling)randomTypeFilling, (TypePovered)randomTypePovered);
                }
                else
                {
                    var randomTypeCaramel = _random.Next(0, 2);
                    var randomTasteCaramel = _random.Next(0, 2);
                    var randomFillinginCaramel = _random.Next(0, 2);
                    var randomForm = _random.Next(0, 2);
                    _sweets[i] = new FormCandy($"Caramel:{i}", randomPrice, randomWeight, (TypeCaramel)randomTypeCaramel, (TasteCaramel)randomTasteCaramel, (TypeFillinginCaramel)randomFillinginCaramel, (FormCandys)randomForm);
                }
            }

            return _sweets;
        }

        public string WriteArrey(Sweetnes[] sweets)
        {
            var listSweets = new StringBuilder();

            foreach (Sweetnes sweetness in sweets)
            {
                PowderForChokolate chokolat = sweetness as PowderForChokolate;
                if (chokolat != null)
                {
                    listSweets.AppendLine($" {chokolat.Name} price: {chokolat.Price} weight: {chokolat.Weight} type chokolate: {chokolat.TypeChokolad}, " +
                        $"the amount of sugar: {chokolat.AmountOfSugar} type filling: {chokolat.TypeFilling}, type povered: {chokolat.TypePovered} ");
                }
                else
                {
                    FormCandy caramel = sweetness as FormCandy;
                    if (caramel != null)
                    {
                        listSweets.AppendLine($" {caramel.Name} price: {caramel.Price} weight: {caramel.Weight} type caramel: {caramel.TasteCaramel}, " +
                            $"Caramel taste : {caramel.TasteCaramel} type filling: {caramel.TypeFillinginCaramel}, forma sweetnes: {caramel.FormCandys} ");
                    }
                }
            }

            return listSweets.ToString();
        }

        public double WeightPresent(Sweetnes[] sweets)
        {
            var weight = 0.0;
            foreach (Sweetnes sweetness in sweets)
            {
                weight += sweetness.Weight;
            }

            return weight;
        }
    }
}
