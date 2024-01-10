

namespace MC_Five_to_Seven.Services.Six
{
    public class SixService : ISixService
    {
        public string OddOrEven(string num)
        {           
            bool isNum = double.TryParse(num, out double result1);
            if (isNum == false)
            {
                return "Your input is not a number";
            }
            else
            {
                double numRes = result1 % 2;
                if (numRes == 0){
                    return $"{num} is even!";
                }
                else{
                    return $"{num} is odd!";
                }

            }
            

            
        }
    }
}