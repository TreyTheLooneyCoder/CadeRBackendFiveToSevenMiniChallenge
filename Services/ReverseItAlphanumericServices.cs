namespace CadeRBackendFiveToSeven.Services
{
    public class ReverseItAlphanumericServices
    {
         public string LetterReverse(string letters)
        {   

            char[] charArray = letters.ToCharArray();
            string reverse = " ";
            for(int i = charArray.Length - 1; i > -1; i--)
            {
                reverse += charArray[i];
            }

            letters = reverse;

            return letters;
        }
    }
}