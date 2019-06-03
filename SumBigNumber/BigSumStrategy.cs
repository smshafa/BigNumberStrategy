﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumber
{
    public class BigSumStrategy : SumStrategy
    {
        public override string Calculate(List<string> stringNum)
        {
            
            string temp = "";

            for (int i = 1; i < stringNum.Count; i++)
            {
                if (i == 1) temp = Add(stringNum[0], stringNum[1]);
                else
                    temp = Add(stringNum[i], temp);
            }

            return temp;
        }



        protected string Add(string num1, string num2)
        {
            int max = 0;    // the maximum of input 
            string Addresult = "";  //final result

            char[] charArr1 = new char[max];    // the frist input 
            char[] charArr2 = new char[max];    // the second input

            // the greater input put into the first row
            if (num1.Length > num2.Length)
            {
                max = num1.Length;
                charArr1 = num1.ToCharArray();
                charArr2 = num2.ToCharArray();
            }
            else
            {
                max = num2.Length;
                charArr1 = num2.ToCharArray();
                charArr2 = num1.ToCharArray();
            }

            // initiate array cell into 0
            char[,] holder = new char[3, max];
            for (int i = 0; i <= 2; i++)
                for (int j = 0; j <= max - 1; j++)
                    holder[i, j] = '0';


            split(charArr1, ref holder, 0, max);
            split(charArr2, ref holder, 1, max);

            int ta = 0; // the first digit of the first input
            int tb = 0; // the first digit of the second input
            char tc = '0';  // the first digit of the result or the second input
            int sum = 0;    //sum two digit
            char carry = '0';

            // ****** main algoritm
            for (int i = max; i > 0; i--)
            {
                ta = Convert.ToInt32(holder[0, i - 1].ToString());  // the first digit
                tb = Convert.ToInt32(holder[1, i - 1].ToString());  // the second digit
                // the result with carry
                sum = ta + tb + Convert.ToInt32(carry.ToString());  //sum two digit(if there was carry in the last setp, it will add it
                //split carry and sum from sum result and put sum into array
                if (sum.ToString().Length > 1)  // there is carry
                {
                    carry = Convert.ToChar(sum.ToString().Substring(0, 1));
                    tc = Convert.ToChar(sum.ToString().Substring(1));
                    holder[2, i - 1] = tc;
                }
                else
                {   // there is not carry so we consider 0
                    tc = Convert.ToChar(sum.ToString());
                    holder[2, i - 1] = Convert.ToChar(tc.ToString());
                    carry = '0';
                }
            }
            // *************
            // convert char result to string result
            for (int i = 0; i < max; i++)
                Addresult += holder[2, i].ToString();
            if (carry == '1') // add the last carry, this carry does not add to sth
                Addresult = carry + Addresult;

            return Addresult;
        }


        /// <summary>
        /// convert two input into a multiDimentional array
        /// </summary>
        /// <param name="charArr"></param>
        /// <param name="holder"></param>
        /// <param name="row"></param>
        /// <param name="max">the maximum length of array</param>
        protected void split(char[] charArr, ref char[,] holder, int row, int max)
        {
            int j = max - 1;
            for (int i = charArr.Length - 1; i >= 0; i--)
                holder[row, j--] = charArr[i];
        }
    }
}
