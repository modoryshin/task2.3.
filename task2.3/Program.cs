using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace task2._3
{
    class Program
    {
        static int Number(string txt)
        {
            txt = txt.Trim(' ');
            int num = Convert.ToInt32(txt);
            return num;
        }

        
        static void Main(string[] args)
        {
            FileStream f = new FileStream("input.txt", FileMode.OpenOrCreate);
            StreamReader r = new StreamReader(f);
            string s1 = r.ReadLine();
            int[] arr = new int[Convert.ToInt32(s1)];
            arr[arr.Length - 1] = Convert.ToInt32(s1);
            int a = 1;
            for (int i =0;i<arr.Length;i++)
            {
                arr[i] = a;
                a++;
            }
            r.Close();
            f.Close();
            FileStream f1 = new FileStream("output.txt", FileMode.OpenOrCreate);
            StreamWriter w = new StreamWriter(f1);
            int tmp = arr[arr.Length - 1];
            if (arr.Length%2 != 0)
            {
                for (int i = arr.Length - 1; i > arr.Length / 2; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[arr.Length / 2] = tmp;
            }
            else
            {
                for (int i = arr.Length - 1; i > (arr.Length / 2-1); i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[arr.Length / 2-1] = tmp;
            }
            foreach (int x in arr)
            {
                w.Write(x + " ");
            }
            w.Close();
            f1.Close();
        }
    }
}
