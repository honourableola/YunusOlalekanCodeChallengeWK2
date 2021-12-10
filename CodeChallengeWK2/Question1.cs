using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeWK2
{
    public class Question1
    {
        //This method checks the validity of a string based on Sherlock's rules
        public string CheckSherlockStringValidity(string test)
        {
            //Declaration of Required variables
            bool isValid  = true;
            string response = string.Empty;
            List<int> charList = new List<int>(); //Stores occurences for each character
            int characterCount = 0; //Keeps count of number of occurence of a charater

            // Checking for the number of occurences of each character
            for(int i = 0; i < test.Length; i++)
            {
                for (int j = 0; j < test.Length; j++)
                {
                    if (test[i] == test[j])
                    {
                        characterCount++;
                    }
                }
                charList.Add(characterCount);
                characterCount = 0;
            }
            
            for(int i = 0; i < charList.Count() -1; i++)
            {
                //Checks if all the character count in the list are equal (first sherlock's validity condition)
                if(charList[i] != charList[i + 1])
                {
                    isValid = false;
                }

                // Checks if the removal of a sigle character makes a string valid (second Sherlock's condition) 
                if (Math.Abs(charList[i] - charList[i + 1]) == 1)
                {
                    isValid = true;
                }
            }

            //Return the appropriate response based on the checks carried out
            if (isValid == false)
            {
                response = "No";
            }
            else
            {
                response = "Yes";
            }

            return response;
        }
    }
}
