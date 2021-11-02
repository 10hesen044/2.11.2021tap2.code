using System;
using System.Collections.Generic;
using System.Text;

namespace _2._11._2021tap2
{
    class Method
    {
        public bool checkString(string text)
        {
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            foreach (var item1 in text)
            {
                if (Char.IsUpper(item1) == true)
                {
                    check1 = true;
                    break;
                }

                else
                    check1 = false;
            }

            foreach (var item2 in text)
            {
                if (Char.IsLetter(item2) == true)
                {
                    check2 = true;
                    break;
                }

                else
                    check2 = false;
            }

            foreach (var item3 in text)
            {
                if (Char.IsDigit(item3) == true)
                {
                    check3 = true;
                    break;
                }

                else
                    check3 = false;
            }

            if (check1 == true && check2 == true && check3 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
