using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWork2
{
    static class Program
    {
        public static void Copies(string s,ref string s1, int n)
        {
            for (int i = 0; i < n; i++)
                Concat(ref s1, s); 
        }


        public static int Words(string s)
        {
            int count = 0;
            bool isLetterOrDigit = false;
            foreach (char ch in s)
            {
                bool currentIsLetterOrDigitr = Char.IsLetterOrDigit(ch);
                if (currentIsLetterOrDigitr && !isLetterOrDigit)
                    count++;
                isLetterOrDigit = currentIsLetterOrDigitr;

            }
            return count;
        }
        public static void Concat(ref string s1, string s2)
        {
            s1 += s2;
        }

        public static string Parse(ref string s, char t)
        {
            string result = "";
            string s1 = "";
            bool find = false;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i-1] == t)
                    find = true;
                if (find)
                    s1 += s[i];
                else
                    result += s[i-1];
            }
            if (find)
                result += t;
            else
                result = s;
            s = result;
            return s1;
        }

        public static string Word(string s)
        {
            string word = "";
            for(int i = 0; i < s.Length; i++)
                if (Char.IsLetterOrDigit(s[i]))
                {
                    word += s[i];
                    for (int j = i + 1; j < s.Length; j++)
                        if (Char.IsLetterOrDigit(s[j]))
                            word += s[j];
                        else
                            break;
                    break;
                }
            return word;
        }

        public static void Delete(ref string s, int n, int l)
        {
            if (l < 0 || n < 0)
                return;
            string trail = (s.Length > n + 1) ? CustomSubstring(s, n + l, s.Length - n - l) : "";
            s = ((n < s.Length) ? CustomSubstring(s, 0, n) : s) + trail;
        }

        public static void Insert(ref string s, string s1, int n)
        {
            if (s.Length < n || n < 0)
                return;
            s = CustomSubstring(s, 0, n) + s1 + CustomSubstring(s, n, s.Length - n);
        }

        public static void Reverse(ref string s)
        {
            string reverseS = "";
            for (int i = s.Length - 1; i >= 0; i--)
                reverseS += s[i];
            s = reverseS;
        }

        public static int Position(string s, string s1)
        {
            int position = -1;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == s1[0])
                {
                    position = i;
                    for (int j = 1; j < s1.Length; j++)
                    {
                        if (i + j >= s.Length)
                        {
                            position = -1;
                            break;
                        }
                        if (s[i + j] != s1[j])
                        {
                            position = -1;
                            break;
                        }
                    }
                    if (position != -1)
                        break;
                }
            return position;
        }

        public static int ReversePosition(string s, string s1)
        {
            int position = -1;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == s1[0])
                {
                    position = i;
                    for (int j = 1; j < s1.Length; j++)
                    {
                        if (i + j >= s.Length)
                        {
                            position = -1;
                            break;
                        }
                        if (s[i + j] != s1[j])
                        {
                            position = -1;
                            break;
                        }
                    }
                }
            return position;
        }

        // Писать кастомынй Substring по мне лишнее, но не знаю все условия. Хоть будет простая реализация, но наплодит много кода
        private static string CustomSubstring(string str, int position, int length)
        {
            int _length = length;
            string subString = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == position)
                    for (int j = i; j < str.Length; j++)
                    {
                        if (_length > 0)
                        {
                            subString += str[j];
                            _length--;
                        }
                    }
            }
            return subString;
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
