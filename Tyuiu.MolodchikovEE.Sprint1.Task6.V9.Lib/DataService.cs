using tyuiu.cources.programming.interfaces.Sprint1;



namespace Tyuiu.MolodchikovEE.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            string[] words = value.Split(' ');
            string newString = "";

            foreach (string word in words)
            {
                if (word.Length > 1)
                {
                    string modifiedWord = word[word.Length - 1] + word.Substring(0, word.Length - 1);
                    newString += modifiedWord + " ";
                }
                else
                {
                    newString += word + " ";
                }
            }
            return newString.Trim();
        }
    }
}
