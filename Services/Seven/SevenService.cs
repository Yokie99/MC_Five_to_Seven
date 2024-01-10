
namespace MC_Five_to_Seven.Services.Seven
{
    public class SevenService : ISevenService
    {
        public string reverseABC(string revMe)
        {
            int length = revMe.Length;
            char[] array = new char[length];
            string reversed = "";
            for (int i = 1; i <= length; i++)
            {
                array[i - 1] = revMe[length - i];
                reversed = reversed + array[i - 1];
            }
            return $"{revMe} reversed is {reversed}";
        }
    }
}