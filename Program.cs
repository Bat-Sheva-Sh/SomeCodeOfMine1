using System;

namespace _12._01hw
{
    class Program
    {

        static void Main(string[] args)
        {
            //dont forget me!!!
            //ex 67
            //BuildString("iabgrtlstypm", 31605);
            //ex 68
            //string[] arr = { "gltas", "ouolt", "oc*lu", "dk**d", "****e", "****n", "****t", "****s" };
            //string s1=FigureOutString(arr);
            //Console.WriteLine(s1);
            //ex 69
            bool b = Func("aghbfeccbaf", "abc");
            Console.WriteLine(b);
            Console.ReadKey();

        }
        //ex 67
        //static string BuildString(string s, int num)
        //{
        //    string st = "", newSt = "";
        //    int n = num, n2 = num, count = 0, last = 0;
        //    while (num != 0)
        //    {
        //        num /= 10;
        //        count++;
        //    }
        //    //string number = "";
        //    for (int i = 0; i < count; i++)
        //    {
        //        last = num % 10;
        //        num /= 10;
        //        st += s[last];
        //        //string str2=string str1.insert(from, subString)
        //    }
        //    //נהפוך את המחרוזת לתוך החדשה ממש ואותה נחזיר!
        //    for (int i = count-1; i<=0; i--)
        //    {
        //        newSt += st[i];
        //    }
        //    return newSt;
        //}

        //ex 68
        //static string FigureOutString(string[] arr)
        //{
        //    string word = "";
        //    string newString = "";
        //    int place = 0;
        //    string old = "";
        //    for (int j = 0; j < arr[0].Length; j++)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i][j] != '*')
        //            {
        //                word += arr[i][j];
        //            }
        //            else
        //                break;
        //        }
        //        word += " ";
        //    }
        //    return newString;
        //}

        //ex 69
        static bool Func(string s1, string s2)
        {
            bool isIt= true;
            //בדיקת תקינות של s2- אותיות קטנות ושונים זה מזה
            for (int i = 0; i < s2.Length; i++)
            {
                //לפי קוד אסקי- שזה אכן אותיות קטנות
                //if((int)s2[i]טווח מסוים)

                for (int j = 0; j < s2.Length; j++)
                {
                    if (i != j && s2[i] == s2[j])
                        return false;
                }
            }
            int[] indexes = new int[s2.Length];
            for (int i = 0; i < s2.Length; i++)
            {
                indexes[i] = s1.IndexOf(s2[i]);
            }
            for (int i = 1; i < indexes.Length; i++)
            {
                if (indexes[i] < indexes[i - 1])
                    return false;
            }
            return isIt;
        }

    }
}
