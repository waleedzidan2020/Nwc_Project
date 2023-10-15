using NWCProject.Models;

namespace NWCProject.Repositories
{
    public class SliceValuesRepository : GeneralRepository<NWC_Default_Slice_Values>
    {
       public List<decimal> Sanitation_Prices = new() { 0.05m, 0.50m, 1.50m, 2.00m, 3.00m };
        public List<decimal> Water_Prices = new() { 0.10m, 1.00m, 3.00m, 4.00m, 6.00m };
        public SliceValuesRepository(NwcDbContext nwcDbContext) : base(nwcDbContext)
        {
        }


        public virtual  decimal Calculate_Sanitation_Price(int Amount_Consumption, int sizeOfcard) {

            var listOfValues=  HelperMethod.Distributethe_amount_of_consumption_among_the_segments(sizeOfcard, Amount_Consumption);

          return  HelperMethod.CalculateValueOfSanitationOrValueOfWater(Sanitation_Prices, listOfValues);
        
        }
        public virtual  decimal Calculate_Water_Price(int Amount_Consumption, int sizeOfcard)
        {

            var listOfValues = HelperMethod.Distributethe_amount_of_consumption_among_the_segments(sizeOfcard, Amount_Consumption);

            return HelperMethod.CalculateValueOfSanitationOrValueOfWater(Water_Prices, listOfValues);

        }
        public void AddSlice() {

            //List<NWC_Default_Slice_Values> listSlice = new List<NWC_Default_Slice_Values>() {

            //new NWC_Default_Slice_Values(){

            //Slice_Code=Guid.NewGuid().ToString().FirstOrDefault(),
            //Slice_Name=""
            
            //}
            
            
            //};
            
            //for (int j = 1; j < 11; j++)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {

            //        NWC_Default_Slice_Values item = new()
            //        {

            //            Slice_Code= Guid.NewGuid().ToString().FirstOrDefault(),
            //            Slice_Name = "",
            //            Sanitation_Price= Sanitation_Prices[i],
            //            Water_Price= Water_Prices[i],
            //            Amount_of_Consumption=i==415*i



            //        };

            //        listSlice.Add(item);
            //    }
            //}
        
        
        }
    }
}
