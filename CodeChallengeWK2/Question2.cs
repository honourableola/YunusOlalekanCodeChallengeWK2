using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeWK2
{
    public class Question2
    {
        //This method finds the super digit of an integer
        public int SuperDigit(string numPart, int concatTimes)
        {
            //Declaration of required variables
            int superDig = int.MaxValue;
            int sum = 0;
            string inputString = string.Empty;

            //Transformation of user inputs (i.e string of digits and number of concatenation required)into the full string
            for(int i = 0; i < concatTimes; i++)
            {
                inputString += numPart;
            }

            // Splitting of digit strings, conversion into integer and summation of digits
            while (superDig > 10) 
            {
                
                for (int i = 0; i < inputString.Length; i++)
                {
                    int num = int.Parse(inputString[i].ToString());
                    sum += num;
                }
                inputString = Convert.ToString(sum); //Converts the sum of digits back to string for repetition of the process
                sum = 0; //Resets the value of sum to zero after the completion of each for loop
                superDig = int.Parse(inputString); //Converts the current string of digits for checking the continuity of the loop      
            }
           
            return superDig;
            
        }
    }
}
