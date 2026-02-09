using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // for ints 1-100 
        // print "A" if divisible by 3, 
        // "B" if divisible by 5, 
        // "AB" if divisible by 3 and 5, 
        // and just the int if none of the above. 
        // Format as "1, 2, A, 4, B, A, 7, 8, A, B, 11, A, 13, 14, AB, 16, 17, ..."

        //initialize variables to use for readability
        bool div3 = false;
        bool div5 = false;
        //using a string concat
        //initialize string
        string strMessage = "";
        for (int i = 1; i < 101; i++)
        {

            //add a comma to everything after the first item.
            //this could also be accomplished by checking if (i > 1), 
            //but since we're manipulating the string strMessage 
            // rather than the variable i, I thought it best to check the string
            if (strMessage.Length != 0)
            {
                strMessage = strMessage + ", ";
            }

            //assign variables to simplify switch
            div3 = (i % 3 == 0);
            div5 = (i % 5 == 0);

            //c# switches are not as friendly as javascript switches, so here's a hack for you.
            //reset combinedValue
            int combinedValue = 0;
            //combinedValue now becomes 
            // 1 if the number is divisble by only 3, 
            // 2 if divisible by only 5, 
            // 3 if divisible by both, 
            // and remains 0 if not divisible by either.
            combinedValue = combinedValue + (div3 ? 1 : 0) + (div5 ? 2 : 0);

            //use a switch to avoid nested if statements
            switch (combinedValue)
            {
                case 3:
                    strMessage = strMessage + "AB";
                    break;
                case 2:
                    strMessage = strMessage + "B";
                    break;
                case 1:
                    strMessage = strMessage + "A";
                    break;
                default:
                    strMessage = strMessage + i;
                    break;
            }
        }


        //using a container
        //initialize list
        List<string> lstMessage = new List<string>();
        for (int i = 1; i < 101; i++)
        {

            //assign variables to simplify switch
            div3 = (i % 3 == 0);
            div5 = (i % 5 == 0);

            //c# switches are not as friendly as javascript switches, so here's a hack for you.
            //reset combinedValue
            int combinedValue = 0;
            //combinedValue now becomes 
            // 1 if the number is divisble by only 3, 
            // 2 if divisible by only 5, 
            // 3 if divisible by both, 
            // and remains 0 if not divisible by either.
            combinedValue = combinedValue + (div3 ? 1 : 0) + (div5 ? 2 : 0);

            //use a switch to avoid nested if statements
            switch (combinedValue)
            {
                case 3:
                    lstMessage.Add("AB");
                    break;
                case 2:
                    lstMessage.Add("B");
                    break;
                case 1:
                    lstMessage.Add("A");
                    break;
                default:
                    lstMessage.Add(i.ToString());
                    break;
            }
        }

        //print the message
        Console.WriteLine("The output of Console.WriteLine(strMessage) is:");
        Console.WriteLine(strMessage);

        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("The output of Console.WriteLine(String.Join(\", \", lstMessage)) is:");
        Console.WriteLine(String.Join(", ", lstMessage));
    }
}