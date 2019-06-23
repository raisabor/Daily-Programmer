using System;

public class Anagram
{
    public bool IsAnagram(string s, string t)
    {

        char[] arr = s.ToCharArray();
        char[] marr = t.ToCharArray();



        int number = 0;


        for (int i = 0; i < arr.Length; i++)

        {


            number += (int)arr[i];

        }


        int number2 = 0;


        for (int i = 0; i < marr.Length; i++)


        {

            number2 += (int)marr[i];


        }


        if (number == number2)

            return true;

        else

            return false;


    }
}
