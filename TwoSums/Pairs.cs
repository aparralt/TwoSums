using System;
using System.Linq;
namespace TwoSums
{
    public class Pairs
    {
        public static void Main()
        {

        }
        public string GetTwoSums(int[] arr, int target)
        {
            //get not only the items but the indexes
            var internalArray = arr.Select((val, i) => new { val, i });
            //initialize the result with 0,0
            int[] result = { 0, 0 };
            //iterate through the internalArray, so we start from left to right
            foreach (var left in internalArray)
            {
                /**
                 * we take the last items of the array since position left.i and check if the sum
                 * of the items is the same as the target and then we then we get the index position of the last
                 * element
                **/
                int rightIndex = internalArray.Where(rigth => rigth.i > left.i).FirstOrDefault(right => right.val + left.val == target)?.i ?? 0;
                if(rightIndex!= 0)
                {
                    result = new int[] { left.i, rightIndex };
                    break;
                }
            }
            //return a string and not an array
            return string.Join(", ",result);
        }
    }
}
