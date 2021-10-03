using System;

namespace Exercises.Level2
{
    public class Triforce
    {
        /// <summary>
        /// !!! COMPLETE TRIANGLE BEFORE ATTEMPTING THIS !!!
        /// 
        /// 
        /// The program:
        ///  You must create a program that echoes a Triforce of a given size N.       
        /// - A triforce is made of 3 identical triangles
        /// - A triangle of size N should be made of N lines
        /// - A triangle's line starts from 1 star, and earns 2 stars each line
        /// 
        /// For example, a Triforce of size 3 will look like:
        ///        
        ///     *
        ///    ***
        ///   *****
        ///  *     *
        /// ***   ***
        ///***** *****
        ///
        /// Another example, a Triforce of size 5 will look like:
        ///
        ///         *
        ///        ***
        ///       *****
        ///      *******
        ///     *********
        ///    *         *
        ///   ***       ***
        ///  *****     *****
        /// *******   *******
        ///********* *********
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>


        public string[] GetTriforce(int n)
        {
            string[] triangles = new string[2 * n];
            if (n == 1)
            {
                triangles[0] = " *";
                triangles[1] = "* *";
                return triangles;
            }
            string spaces = " ";
            for (int i = 1; i <= n - 1; i++)
            {
                spaces = spaces + " ";
            }
            for (int j = 1; j <= 2 * n - 1; j++)
            {
                triangles[2 * n - 1] = triangles[2 * n - 1] + "*";
            }
            for (int nstr = 2 * n - 2; nstr >= n; nstr--)
            {
                triangles[nstr] = triangles[nstr + 1].Remove(triangles[nstr + 1].Length - 2, 2);
                triangles[nstr] = " " + triangles[nstr];
                triangles[nstr - n] = spaces + triangles[nstr];
            }
            spaces = "  ";
            for (int nstr = 2 * n - 2; nstr >= n; nstr--)
            {
                triangles[nstr] = triangles[nstr] + spaces + triangles[nstr];
                spaces = spaces + " ";
            }
            spaces = spaces.Remove(spaces.Length - 1, 1);
            triangles[n - 1] = spaces + triangles[2 * n - 1];
            triangles[2 * n - 1] = triangles[2 * n - 1] + " " + triangles[2 * n - 1];
            return triangles;
        }
    }
}
