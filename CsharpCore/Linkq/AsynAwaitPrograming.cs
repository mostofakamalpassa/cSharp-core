using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Linkq
{
    internal class AsynAwaitPrograming
    {

        public async Task<int> GetPrimesCountAsync(int start, int count)
        {
            return await Task.Run(() =>
            ParallelEnumerable.Range(start, count).Count(n =>
            Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));
        }

        async Task Go()
        {
            await PrintAnswerToLife();
            Console.WriteLine("Done");
        }
        async Task PrintAnswerToLife()
        {
            int answer = await GetAnswerToLife();
            Console.WriteLine(answer);
        }
        async Task<int> GetAnswerToLife()
        {
            await Task.Delay(5000);
            int answer = 21 * 2;
            return answer;
        }

        static async Task<IEnumerable<int>> RangeTaskAsync(int start, int count,int delay)
        {
            List<int> data = new List<int>();
            for (int i = start; i < start + count; i++)
            {
                await Task.Delay(delay);
                data.Add(i);
            }
            return data;
        }

        async Task B()
        {
            for (int i = 0; i < 1000; i++)
                await C().ConfigureAwait(false);
        }

        async Task C() {  }
    }
}
