using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public static class RandomExtension
    {
        /// <summary>
        /// System.Random 擴充方法
        /// </summary>
        /// <param name="random">System.Random</param>
        /// <param name="start">起始數字</param>
        /// <param name="end">結束數字</param>
        /// <returns>回傳值定範圍內容的浮點數</returns>
        public static double NextDouble(this Random random, double start, double end)
        {
            return random.NextDouble() * (end - start) + start;
        }

        /// <summary>
        /// System.Random 擴充方法
        /// </summary>
        /// <param name="random">System.Random</param>
        /// <param name="start">起始數字</param>
        /// <param name="end">結束數字</param>
        /// <returns>回傳值定範圍內容的整數</returns>
        public static int Next(this Random random, int start, int end)
        {
            return random.Next() * (end - start) + start;
        }
    }
}