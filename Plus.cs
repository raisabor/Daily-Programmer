using System;

public class Plus
{
        public int[] PlusOne(int[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (i == digits.Length - 1)
                {
                    digits[i]++;
                }


            }

            return digits;


        }
   
}
