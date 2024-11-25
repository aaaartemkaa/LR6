using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Kurs_pr_Bayer_A_A
{
    internal static class sorter
    {
        public static long ShellSortingMethodOfDividingInHalf(S_List list)
        {
            var gap = list.Length / 2;
            var sw = new Stopwatch();
            sw.Start();
            while (gap >= 1)
            {
                int i, j;
                for (i = gap; i < list.Length; i++)
                {
                    int value = list.GetNode(i).data;
                    for (j = i - gap; (j >= 0) && (list.GetNode(j).data > value); j -= gap)
                        list.GetNode(j + gap).data = list.GetNode(j).data;
                    list.GetNode(j + gap).data = value;
                }
                gap = gap / 2;
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
        public static long ShellSortingMethodVirt(S_List list)
        {
            int gap = list.Length / 2;
            var sw = new Stopwatch();
            sw.Start();
            while (gap >= 1)
            {
                int i, j;
                for (i = gap; i < list.Length; i++)
                {
                    int value = list.GetNode(i).data;
                    for (j = i - gap; (j >= 0) && (list.GetNode(j).data > value); j -= gap)
                        list.GetNode(j + gap).data = list.GetNode(j).data;
                    list.GetNode(j + gap).data = value;
                }
                gap = (gap - 1) / 3;
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
        public static long ShellSortingMethodKnyt(S_List list)
        {
            int gap = (int)Math.Pow(3, (int)Math.Log(list.Length, 3));
            var sw = new Stopwatch();
            sw.Start();
            while (gap >= 1)
            {
                int i, j;
                for (i = gap; i < list.Length; i++)
                {
                    int value = list.GetNode(i).data;
                    for (j = i - gap; (j >= 0) && (list.GetNode(j).data > value); j -= gap)
                        list.GetNode(j + gap).data = list.GetNode(j).data;
                    list.GetNode(j + gap).data = value;
                }
                gap = gap / 3;
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;

        }
    }
}
