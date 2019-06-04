/* 
   Author: John Hong
   Summary: This program takes a given input and removes
            duplicate characters.
   Date: 5/28/19          
*/  


class Solution
{
     public static string DeleteDupes(string words)
     {
        // Variable that will be used to create a new
        // string containing no duplicates
        string deletedW = "";        
        for(int i = 0; i < words.Length; i++)
        {
            // Condition statement: "If the deletedW doesn't
            // contain the characters in the index of
            // words string"
            if(!deletedW.Contains(words[i]))
            {
                // Concatenates successive characters.
                deletedW += words[i];
            }
            
        }

        return deletedW;

     }
    
    static void Main()
    {
        string input = "dddooogg";

        Console.WriteLine(DeleteDupes(input));
    }
    
}
