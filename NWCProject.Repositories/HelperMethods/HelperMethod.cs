using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Repositories
{
    public static class HelperMethod
    {
        public static List<int> Distributethe_amount_of_consumption_among_the_segments(int sizeOfCard, int Amount_Consumption, int NumberOfSlides = 5)
        {
            List<int> results = new();

            if (Amount_Consumption > (sizeOfCard * 4))
            {


                for (int i = 0; i < NumberOfSlides - 1; i++)
                {

                    Amount_Consumption = Amount_Consumption - sizeOfCard;
                    results.Add(sizeOfCard);

                }
                results.Add(Amount_Consumption);
                return results;
            }
            else
            {

                int rest = Amount_Consumption % sizeOfCard;
                while (Amount_Consumption != rest)
                {

                    Amount_Consumption = Amount_Consumption - sizeOfCard;


                    results.Add(sizeOfCard);

                }
                results.Add(rest);

                return results;

            }

        }
        public static decimal CalculateValueOfSanitationOrValueOfWater(List<decimal> sliceValues, List<int> segment_consumption_distribution)
        {
            decimal sum = 0;

            for (int i = 0; i < segment_consumption_distribution.Count; i++)
            {

                sum = (segment_consumption_distribution[i] * sliceValues[i]) + sum;


            }
            return sum;


        }
    }
}
