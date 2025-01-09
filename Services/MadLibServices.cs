namespace CadeRBackendFiveToSeven.Services
{
    public class MadLibServices
    {
        public string MadLibStory(string adjective1, string noun1, string verb1, string place, string adjective2, string animal, string verb2, string noun2,string emotion,string verb3)
        {
            return $"A {adjective1} {noun1} decided to {verb1} through the {place} with a {adjective2} {animal}. They {verb2} a {noun2} and felt {emotion} as they {verb3}.";
        }
    }
}