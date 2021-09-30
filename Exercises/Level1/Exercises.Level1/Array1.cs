using System;

namespace Exercises.Level1
{
    /// <summary>
    /// Basic array problems -- no loops.. Use a[0], a[1], ... to access elements in an array, a.Length is the length of array.
    /// Allocate a new array like this: int[] a = new int[10];
    /// </summary>
    public class Array1
    {
        /// <summary>
        /// Given an array of ints, return true if 6 appears as either the first or last element in the
        /// array. The array will be length 1 or more.
        /// 
        /// firstLast6([1, 2, 6]) → true
        /// firstLast6([6, 1, 2, 3]) → true
        /// firstLast6([13, 6, 1, 2, 3]) → false
        /// </summary>
        public bool FirstLast6(int[] nums)
        {
            int lastIndex = nums.Length - 1;
            if (lastIndex < 0)
            {
                return false;
            }
            return nums[0] == 6 || nums[lastIndex] == 6;
        }

        /// <summary>
        /// Given an array of ints, return true if the array is length 1 or more, and the first element
        /// and the last element are equal.
        /// 
        /// sameFirstLast([1, 2, 3]) → false
        /// sameFirstLast([1, 2, 3, 1]) → true
        /// sameFirstLast([1, 2, 1]) → true
        /// </summary>
        public bool SameFirstLast(int[] nums)
        {
            int lastIndex = nums.Length - 1;
            return lastIndex >= 0 && nums[0] == nums[lastIndex];
        }

        /// <summary>
        /// Return an int array length 3 containing the first 3 digits of pi, {3, 1, 4}.
        /// 
        /// makePi() → [3, 1, 4]
        /// </summary>
        public int[] MakePi()
        {
            int[] Array = new int[3] { 3, 1, 4 };
            return Array;
        }

        /// <summary>
        /// Given 2 arrays of ints, a and b, return true if they have the same first element or they
        /// have the same last element. Both arrays will be length 1 or more.
        /// 
        /// commonEnd([1, 2, 3], [7, 3]) → true
        /// commonEnd([1, 2, 3], [7, 3, 2]) → false
        /// commonEnd([1, 2, 3], [1, 3]) → true
        /// </summary>
        public bool CommonEnd(int[] a, int[] b)
        {
            int lastIndexa = a.Length - 1;
            int lastIndexb = b.Length - 1;
            if (lastIndexa < 0 || lastIndexb < 0)
            { 
                return false; 
            }
            return a[0] == b[0] || b[lastIndexb] == a[lastIndexa];
        }

        /// <summary>
        /// Given an array of ints length 3, return the sum of all the elements.
        /// 
        /// sum3([1, 2, 3]) → 6
        /// sum3([5, 11, 2]) → 18
        /// sum3([7, 0, 0]) → 7
        /// </summary>
        public int Sum3(int[] nums)
        {
            int lastIndex = nums.Length - 1;
            int summ = 0;
            for (int i = 0; i <= lastIndex; i++)
            {
                summ = summ + nums[i];
            }
            return summ;
        }

        /// <summary>
        /// Given an array of ints length 3, return an array with the elements "rotated left" so {1, 2,
        /// 3} yields {2, 3, 1}.
        /// 
        /// rotateLeft3([1, 2, 3]) → [2, 3, 1]
        /// rotateLeft3([5, 11, 9]) → [11, 9, 5]
        /// rotateLeft3([7, 0, 0]) → [0, 0, 7]
        /// </summary>
        public int[] RotateLeft3(int[] nums)
        {
            int lastIndex = nums.Length - 1;
            int first_nums = nums[0];
            for (int i=0;i<lastIndex;i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[lastIndex] = first_nums;
            return nums;
        }

        /// <summary>
        /// Given an array of ints length 3, return an array with the elements "rotated left" so {1, 2,
        /// 3} yields {2, 3, 1}.
        /// 
        /// reverse3([1, 2, 3]) → [3, 2, 1]
        /// reverse3([5, 11, 9]) → [9, 11, 5]
        /// reverse3([7, 0, 0]) → [0, 0, 7]
        /// </summary>
        public int[] Reverse3(int[] nums)
        {
            int lastIndex = 2;
            int[] Array = new int[lastIndex+1];
            for(int i=0;i<=lastIndex;i++)
            {
                Array[i] = nums[lastIndex - i];
            }
            return Array;
        }

        /// <summary>
        /// Given an array of ints length 3, figure out which is larger, the first or last element in the
        /// array, and set all the other elements to be that value. Return the changed array.
        /// 
        /// maxEnd3([1, 2, 3]) → [3, 3, 3]
        /// maxEnd3([11, 5, 9]) → [11, 11, 11]
        /// maxEnd3([2, 11, 3]) → [3, 3, 3]
        /// </summary>
        public int[] MaxEnd3(int[] nums)
        {
            int lastIndex = nums.Length - 1;
            int maxValue = Math.Max(nums[0], nums[lastIndex]);
            for (int i = 0; i <= lastIndex; i++) 
            {
                nums[i] = maxValue;
            }
            return nums;
        }

        /// <summary>
        /// Given an array of ints, return the sum of the first 2 elements in the array. If the array
        /// length is less than 2, just sum up the elements that exist, returning 0 if the array is length
        /// 0.
        /// 
        /// sum2([1, 2, 3]) → 3
        /// sum2([1, 1]) → 2
        /// sum2([1, 1, 1, 1]) → 2
        /// </summary>
        public int Sum2(int[] nums)
        {
            int lastIndex = nums.Length - 1;
            if (lastIndex == 0)
            {
                return nums[0];
            }
            if (lastIndex<0)
            { return 0; }
            return nums[0] + nums[1];
        }

        /// <summary>
        /// Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their
        /// middle elements.
        /// 
        /// middleWay([1, 2, 3], [4, 5, 6]) → [2, 5]
        /// middleWay([7, 7, 7], [3, 8, 0]) → [7, 8]
        /// middleWay([5, 2, 9], [1, 4, 5]) → [2, 4]
        /// </summary>
        public int[] MiddleWay(int[] a, int[] b)
        {
            int[] array = new int[2];
            array[0] = a[1];
            array[1] = b[1];
            return array;
        }

        /// <summary>
        /// Given an array of ints, return a new array length 2 containing the first and last elements
        /// from the original array. The original array will be length 1 or more.
        /// 
        /// makeEnds([1, 2, 3]) → [1, 3]
        /// makeEnds([1, 2, 3, 4]) → [1, 4]
        /// makeEnds([7, 4, 6, 2]) → [7, 2]
        /// </summary>
        public int[] MakeEnds(int[] nums)
        {
            int lastIndex = nums.Length - 1;
           int[] array=new int[2];
            array[0] = nums[0];
            array[1] = nums[lastIndex];
            return array;
        }

        /// <summary>
        /// Given an int array length 2, return true if it contains a 2 or a 3.
        /// 
        /// has23([2, 5]) → true
        /// has23([4, 3]) → true
        /// has23([4, 5]) → false
        /// </summary>
        public bool Has23(int[] nums)
        {
            int lastIndex = nums.Length - 1;
            int i=0;
            while (i<=lastIndex)
            {
                if (nums[i]==2 || nums[i] == 3)
                {
                    return true;
                }
                i++;
            }
            return false;
        }

        /// <summary>
        /// Given an int array length 2, return true if it does not contain a 2 or 3.
        /// 
        /// no23([4, 5]) → true
        /// no23([4, 2]) → false
        /// no23([3, 5]) → false
        /// </summary>
        public bool No23(int[] nums)
        {
            int lastIndex = nums.Length - 1;
            int i = 0;
            while (i <= lastIndex)
            {
                if(nums[i]==2 || nums[i]==3)
                { 
                    return false;
                }
                i++;
            }
            return true;
        }

        /// <summary>
        /// Given an int array, return a new array with double the length where its last element is the
        /// same as the original array, and all the other elements are 0. The original array will be
        /// length 1 or more. Note: by default, a new int array contains all 0's.
        /// 
        /// makeLast([4, 5, 6]) → [0, 0, 0, 0, 0, 6]
        /// makeLast([1, 2]) → [0, 0, 0, 2]
        /// makeLast([3]) → [0, 3]
        /// </summary>
        public int[] MakeLast(int[] nums)
        {
            int nums_length = nums.Length;
            int[] array = new int[nums_length * 2];
            array[nums_length * 2 - 1] = nums[nums_length - 1];
            return array;
        }

        /// <summary>
        /// Given an int array, return true if the array contains 2 twice, or 3 twice. The array will be
        /// length 0, 1, or 2.
        /// 
        /// double23([2, 2]) → true
        /// double23([3, 3]) → true
        /// double23([2, 3]) → false
        /// </summary>
        public bool Double23(int[] nums)
        {
            int nums_length = nums.Length;
            if (nums_length <= 1)
            {
                return false;
            }
            return (nums[0] == 2 && nums[0] == nums[1]) || (nums[0] == 3 && nums[0] == nums[1]);
        }

        /// <summary>
        /// Given an int array length 3, if there is a 2 in the array immediately followed by a 3, set the
        /// 3 element to 0. Return the changed array.
        /// 
        /// fix23([1, 2, 3]) → [1, 2, 0]
        /// fix23([2, 3, 5]) → [2, 0, 5]
        /// fix23([1, 2, 1]) → [1, 2, 1]
        /// </summary>
        public int[] Fix23(int[] nums)
        {
            for( int i=0;i<=1;i++)
            {
                if (nums[i]==2 && nums[i + 1] == 3)
                {
                    nums[i + 1] = 0;
                }
            }
            return nums;
        }

        /// <summary>
        /// Start with 2 int arrays, a and b, of any length. Return how many of the arrays have 1 as
        /// their first element.
        /// 
        /// start1([1, 2, 3], [1, 3]) → 2
        /// start1([7, 2, 3], [1]) → 1
        /// start1([1, 2], []) → 1
        /// </summary>
        public int Start1(int[] a, int[] b)
        {
            int i = 0;
            if (a.Length > 0)
            {
                if (a[0] == 1)
                {
                    i++;
                }
            }
            if (b.Length > 0)
            {
                if (b[0] == 1)
                {
                    i++;
                }
            }
            return i;
        }

        /// <summary>
        /// Start with 2 int arrays, a and b, each length 2. Consider the sum of the values in each
        /// array. Return the array which has the largest sum. In event of a tie, return a.
        /// 
        /// biggerTwo([1, 2], [3, 4]) → [3, 4]
        /// biggerTwo([3, 4], [1, 2]) → [3, 4]
        /// biggerTwo([1, 1], [1, 2]) → [1, 2]
        /// </summary>
        public int[] BiggerTwo(int[] a, int[] b)
        {
            int suma = a[0] + a[1];
            int sumb = b[0] + b[1];
            if (suma == sumb)
            {
                return a;
            }
            if (suma > sumb)
            {
                return a;
            }
            return b;
        }

        /// <summary>
        /// Given an array of ints of even length, return a new array length 2 containing the middle
        /// two elements from the original array. The original array will be length 2 or more.
        /// 
        /// makeMiddle([1, 2, 3, 4]) → [2, 3]
        /// makeMiddle([7, 1, 2, 3, 4, 9]) → [2, 3]
        /// makeMiddle([1, 2]) → [1, 2]
        /// </summary>
        public int[] MakeMiddle(int[] nums)
        {
            int nums_length = nums.Length;
            int[] array = new int[2];
            array[0] = nums[nums_length / 2 - 1];
            array[1] = nums[nums_length / 2 ];
            return array;
        }

        /// <summary>
        /// Given 2 int arrays, each length 2, return a new array length 4 containing all their
        /// elements.
        /// 
        /// plusTwo([1, 2], [3, 4]) → [1, 2, 3, 4]
        /// plusTwo([4, 4], [2, 2]) → [4, 4, 2, 2]
        /// plusTwo([9, 2], [3, 4]) → [9, 2, 3, 4]
        /// </summary>
        public int[] PlusTwo(int[] a, int[] b)
        {
            int[] array = new int[] { a[0], a[1], b[0], b[1] };
            return array;
        }

        /// <summary>
        /// Given an array of ints, swap the first and last elements in the array. Return the modified
        /// array. The array length will be at least 1.
        /// 
        /// swapEnds([1, 2, 3, 4]) → [4, 2, 3, 1]
        /// swapEnds([1, 2, 3]) → [3, 2, 1]
        /// swapEnds([8, 6, 7, 9, 5]) → [5, 6, 7, 9, 8]
        /// </summary>
        public int[] SwapEnds(int[] nums)
        {
            int lastIndex = nums.Length - 1;
            int first_nums = nums[lastIndex];
            nums[lastIndex] = nums[0];
            nums[0] = first_nums;
            return nums;
        }

        /// <summary>
        /// Given an array of ints of odd length, return a new array length 3 containing the elements
        /// from the middle of the array. The array length will be at least 3.
        /// 
        /// midThree([1, 2, 3, 4, 5]) → [2, 3, 4]
        /// midThree([8, 6, 7, 5, 3, 0, 9]) → [7, 5, 3]
        /// midThree([1, 2, 3]) → [1, 2, 3]
        /// </summary>
        public int[] MidThree(int[] nums)
        {
            int lastIndex = nums.Length - 1;
            int[] array = new int[] { nums[lastIndex / 2 - 1], nums[lastIndex / 2], nums[lastIndex / 2 + 1] };
            return array;
        }

        /// <summary>
        /// Given an array of ints of odd length, look at the first, last, and middle values in the array
        /// and return the largest. The array length will be a least 1.
        /// 
        /// maxTriple([1, 2, 3]) → 3
        /// maxTriple([1, 5, 3]) → 5
        /// maxTriple([5, 2, 3]) → 5
        /// </summary>
        public int MaxTriple(int[] nums)
        {
            int maximum = 0;
            int lastIndex=nums.Length-1;
            maximum = Math.Max(nums[0], nums[lastIndex / 2]) ;
            maximum = Math.Max(maximum, nums[lastIndex]);
            return maximum;

        }

        /// <summary>
        /// Given an int array of any length, return a new array of its first 2 elements. If the array is
        /// smaller than length 2, use whatever elements are present.
        /// 
        /// frontPiece([1, 2, 3]) → [1, 2]
        /// frontPiece([1, 2]) → [1, 2]
        /// frontPiece([1]) → [1]
        /// </summary>
        public int[] FrontPiece(int[] nums)
        {
            int nums_length = nums.Length;
            if (nums_length<2)
            {
                return nums;
            }
            int[] array = new int[2];
            array[0] = nums[0];
            array[1] = nums[1];
            return array;

        }

        /// <summary>
        /// We'll say that a 1 immediately followed by a 3 in an array is an "unlucky" 1. Return true if
        /// the given array contains an unlucky 1 in the first 2 or last 2 positions in the array.
        /// 
        /// unlucky1([1, 3, 4, 5]) → true
        /// unlucky1([2, 1, 3, 4, 5]) → true
        /// unlucky1([1, 1, 1]) → false
        /// </summary>
        public bool Unlucky1(int[] nums)
        {
            int lastindex = nums.Length-1;
            if (lastindex<1)
            {
                return false;   
            }
            if (lastindex == 1)
            {
                if (nums[0] == 1 && nums[1] == 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }   
            int i = 0;
            while (i <= 1)
            {
                if ((nums[i]==1 && nums[i+1]==3)  || (nums[lastindex - i - 1] == 1 && nums[lastindex - i] == 3))
                { 
                    return true;
                }
                
                i++;
            }
            return false;
        }

        /// <summary>
        /// Given 2 int arrays, a and b, return a new array length 2 containing, as much as will fit, the
        /// elements from a followed by the elements from b. The arrays may be any length, including
        /// 0, but there will be 2 or more elements available between the 2 arrays.
        /// 
        /// make2([4, 5], [1, 2, 3]) → [4, 5]
        /// make2([4], [1, 2, 3]) → [4, 1]
        /// make2([], [1, 2]) → [1, 2]
        /// </summary>
        public int[] Make2(int[] a, int[] b)
        {
            int a_length = a.Length;
            int[] array = new int[2];
            if (a_length >= 2)
            {
                array[0] = a[0];
                array[1] = a[1];

            }
            else if (a_length == 0)
            {
                array[0] = b[0];
                array[1] = b[1];
            }
            else
            {
                array[0] = a[0];
                array[1] = b[0];
                
            }
            return array;
        }

            /// <summary>
            /// Given 2 int arrays, a and b, of any length, return a new array with the first element of
            /// each array. If either array is length 0, ignore that array.
            /// 
            /// front11([1, 2, 3], [7, 9, 8]) → [1, 7]
            /// front11([1], [2]) → [1, 2]
            /// front11([1, 7], []) → [1]
            /// </summary>
            public int[] Front11(int[] a, int[] b)
        {
            int a_length = a.Length;
            int b_length = b.Length;
            if ((a_length + b_length) == 0)
            {
                int[] array = new int[0];
                return array;
            }
            if (a_length==0)
            {
                int[] array = new int[1] { b[0] };
                return array;
            }
            if (b_length == 0)
            {
                int[] array = new int[1] { a[0] };
                return array;
            }
            else
            {
                int[] array = new int[2] { a[0], b[0] };
                return array;
            }
            
        }
    }
}
