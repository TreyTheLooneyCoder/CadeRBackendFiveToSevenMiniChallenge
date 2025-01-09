namespace CadeRBackendFiveToSeven.Services
{
    public class OddEvenServices
    {
        public string OddOrEven(int checkedNum)
        {
            checkedNum %= 2;

            if(checkedNum == 0)
            {
                return "Your number is even.";
            }
            else
            {
                return "Your number is odd.";  
            }
        }
        
    }
}