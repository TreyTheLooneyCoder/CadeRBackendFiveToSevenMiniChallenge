namespace CadeRBackendFiveToSeven.Services
{
    public class ReverseItNumbersServices
    { 
        
        public string NumReverse(int reverseNum)
        {
            int reversed = 0;

            while (reverseNum>0) 
            {
                reversed = reversed * 10 + reverseNum % 10;
                reverseNum /= 10;
            } 

            reverseNum = reversed;
            return reverseNum.ToString();
        }
    }
}