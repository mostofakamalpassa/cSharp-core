using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Linkq
{
    public class LinqItems
    {

        public void FirstAndLast()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int first = numbers.First();
            int last = numbers.Last();
            int evenFirst = numbers.First(x => x / 2 == 0);
            int evenLast = numbers.Last(x => x / 2 == 0);
            //int firstCon = numbers.First(x => x > 10);
            int lastCon = numbers.FirstOrDefault(x => x > 10);
            int total = numbers.Sum(x => x);
            double avag = numbers.Average(x => x);
            int totalCount = numbers.Count();


            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

            int max = names.Max(x => x.Length);
            int min = names.Min(x => x.Length);
            int digitCount = "pa55w0rd".Count(c => char.IsDigit(c)); // 3
            int smallest = numbers.Max(n => n % 10); // 8;

            int sum = numbers.Aggregate(0, (total, n) => total + n); // 6

          
            int x = numbers.Aggregate(0, (prod, n) => prod * n); // 0*1*2*3 = 0
            int y = numbers.Aggregate((prod, n) => prod * n); // 1*2*3 = 6

            int sums = numbers.Select(n => n * n).Aggregate((total, n) => total + n);

            bool hasAThree = new int[] { 2, 3, 4 }.Contains(3); // true;


        }
    }
}
