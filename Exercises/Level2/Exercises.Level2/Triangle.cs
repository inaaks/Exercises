using System;

namespace Exercises.Level2
{
    public class Triangle
    {
        /// <summary>
        /// Note: compleete half trangle first
        /// 
        /// The program:
        ///  You must create a triangle. 
        ///  n is the number of lines a triangle will have.
        ///  Triangle body has to be made out of "*",
        ///  so result should for 3 be like:
        ///  * 
        /// ***
        ///*****
        /// 
        /// Example of 5:
        /// 
        ///    *
        ///   ***
        ///  *****
        /// *******
        ///*********
        ///
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string[] GetTRiangle(int n)
        {
            string[] stars = new string[n];
            for (int nstr=1;nstr<n*2;nstr++)
            {
                stars[n-1] = stars[n-1] + "*";
            }
            for (int nstr=n-2; nstr>=0;nstr--)
            {
                stars[nstr] = stars[nstr + 1].Remove(stars[nstr+1].Length- 2,2);
                stars[nstr] = " " + stars[nstr];
            }
            return stars;
        }
    }
}
