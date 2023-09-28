using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Median_of_Two_Sorted_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] nums1 = new int[n];
            int[] nums2 = new int[m];
            double medi;
            for (int t = 0; t < n; t++)
            {
                nums1[t] = t + 1;
            }
            for (int t = 0; t < m; t++)
            {
                nums2[t] = t + 6;
            }
            List<int> merged= new List<int>();
            int i = 0, j = 0;

            while(i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    merged.Add(nums1[i++]);
                } else
                {
                    merged.Add(nums2[j++]);
                }
            }

            while (i < nums1.Length) merged.Add(nums1[i++]);
            while (j < nums2.Length) merged.Add(nums2[j++]);

            int mid = merged.Count / 2;
            if (merged.Count % 2 == 0)
            {
                medi = (merged[mid - 1] + merged[mid]) / 2.0;
            }
            else
            {
                medi = merged[mid];
            }
            Console.WriteLine(medi);
            Console.ReadLine();

        }
    }
}
