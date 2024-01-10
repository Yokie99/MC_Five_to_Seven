
namespace MC_Five_to_Seven.Services.Seven123
{
    public class Seven123Service : ISeven123Service
    {
        public string reverse123(string revMe)
        {
            bool isNum = double.TryParse(revMe, out double num);

            if (isNum)
            {
                int length = revMe.Length;
                char[] array = new char[length];
                string reversed = "";
                for (int i = 1; i <= length; i++)
                {
                    array[i - 1] = revMe[length - i];
                    reversed = reversed + array[i - 1];
                }
                return $"Your number {revMe}, reversed is {reversed}";
            }
            else
            {
                return $"I can only reverse numbers, {revMe} is not a number";
            }

        }
    }
}