using System;
using System.Collections.Generic;
using System.Linq;

namespace HREqualizeTheArray {
    class Program {

        static void Main(string[] args) {

            int[] arr = new int[] { 5, 1, 3, 3, 6, 3, 5, 5, 6, 3 }; // 3 most common. 6 minimum deletions

            // find element with most appearances
            // count number of elements that != most common

            int len = arr.Length;

            var dict = new Dictionary<int, int>();

            foreach (int i in arr) {
                if (!dict.ContainsKey(i)) {
                    dict[i] = 0;
                }
                dict[i]++;
            }
            int sum = 0;
            var highVal = dict.Values.Max();
            foreach (var i in dict) {
                sum += i.Value;
            }
            int minSub = sum - highVal;
            Console.WriteLine(minSub);
        }
    }
}
