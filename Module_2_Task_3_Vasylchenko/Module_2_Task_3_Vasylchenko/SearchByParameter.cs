using Module_2_Task_3_Vasylchenko.Chokolad;

namespace Module_2_Task_3_Vasylchenko
{
    public static class SearchByParameter
    {
        public static Sweetnes[] Search(this Sweetnes[] arrey, TypesOfChokolate typesOfChokolate, double weight)
        {
            var sweetnes = new Sweetnes[15];
            var caunterSweetness = 0;
            foreach (Sweetnes sweetness in arrey)
            {
                PowderForChokolate sweetCriteria = sweetness as PowderForChokolate;
                if (sweetCriteria != null)
                {
                    if (sweetCriteria.TypeChokolad == typesOfChokolate && sweetCriteria.Weight > weight)
                    {
                        sweetnes[caunterSweetness] = sweetness;
                        caunterSweetness++;
                    }
                }
            }

            return sweetnes;
        }
    }
}
