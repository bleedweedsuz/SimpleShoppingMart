using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2NEngineFactory
{
    class E2NEngine
    {
        private String upto_ninteen(Int32 n)
        {
            String result = "";
            result = one_to_ninteen(n);
            return result;
        }
        private string one_to_ninteen(Int32 n)
        {
            String digitName = "";
            if (n == 0)
            {
                digitName = "";
            }
            else if (n == 1)
            {
                digitName = "one";
            }
            else if (n == 2)
            {
                digitName = "two";
            }
            else if (n == 3)
            {
                digitName = "three";
            }
            else if (n == 4)
            {
                digitName = "four";
            }
            else if (n == 5)
            {
                digitName = "five";
            }
            else if (n == 6)
            {
                digitName = "six";
            }
            else if (n == 7)
            {
                digitName = "seven";
            }
            else if (n == 8)
            {
                digitName = "eight";
            }
            else if (n == 9)
            {
                digitName = "nine";
            }
            else if (n == 10)
            {
                digitName = "ten";
            }
            else if (n == 11)
            {
                digitName = "eleven";
            }
            else if (n == 12)
            {
                digitName = "twelve";
            }
            else if (n == 13)
            {
                digitName = "thirteen";
            }
            else if (n == 14)
            {
                digitName = "fourteen";
            }
            else if (n == 15)
            {
                digitName = "fifteen";
            }
            else if (n == 16)
            {
                digitName = "sixteen";
            }
            else if (n == 17)
            {
                digitName = "seventeen";
            }
            else if (n == 18)
            {
                digitName = "eighteen";
            }
            else if (n == 19)
            {
                digitName = "nineteen";
            }
            return digitName;
        }
        private String ten_details(Int32 n)
        {
            String result = "";
            Int32 ten, one;
            if(n <20){
                result = upto_ninteen(n);
            }
            else
            {
                one = n % 10;
                ten = n / 10;
                result = tens(ten) + " " + one_to_ninteen(one);
            }
            return result;
        }
        private String tens(Int32 n)
        {
            String digitName = "";
            if (n == 2)
            {
                digitName = "twenty";
            }
            else if (n == 3)
            {
                digitName = "thirty";
            }
            else if (n == 4)
            {
                digitName = "forty";
            }
            else if (n == 5)
            {
                digitName = "fifty";
            }
            else if (n == 6)
            {
                digitName = "sixty";
            }
            else if (n == 7)
            {
                digitName = "seventy";
            }
            else if (n == 8)
            {
                digitName = "eighty";
            }
            else if (n == 9)
            {
                digitName = "ninety";
            }
            return digitName;
        }
        private String hundred_detail(Int32 n)
        {
            String result = "";
            Int32 hundred, ten;
            hundred = n / 100;
            ten = n % 100;
            String r1 = one_to_ninteen(hundred);
            String r2 = ten_details(ten);
            result = r1 + " hundred " + r2;
            if (r1.Trim() == "" && r2.Trim() == "")
            {
                result = "";
            }
            else if (r1.Trim() == "")
            {
                result = r2;
            }
            return result;
        }
        private String thousand_detail(Int32 n)
        {
            String result = "";
            Int32 thousand, hundred;
            thousand = n / 1000;
            hundred = n % 1000;

            String r1 = one_to_ninteen(thousand);
            String r2 = hundred_detail(hundred);
            result = r1 + " thousand " + r2;

            if (r1.Trim() == "" && r2.Trim() == "")
            {
                result = "";
            }
            else if (r1.Trim() == "") {
                result = r2;
            }
            return result;
        }
        private String ten_thousand_detail(Int32 n)
        {
            String result = "";
            Int32 ten_thousand, thousand;
            ten_thousand = n / 1000;
            thousand = n % 1000;

            String r1 = hundred_detail(ten_thousand);
            String r2 = hundred_detail(thousand);
            result = r1 + " thousand " + r2;

            if (r1.Trim() == "" && r2.Trim() == "")
            {
                result = "";
            }
            else if (r1.Trim() == "")
            {
                result = r2;
            }
            return result;
        }
        private String lakh_detail(Int32 n)
        {
            String result = "";
            Int32 lakh, ten_thousand;
            lakh = n / 100000;
            ten_thousand = n % 100000;

            String r1 = one_to_ninteen(lakh);
            String r2 = ten_thousand_detail(ten_thousand);
            result = r1 + " lakh " + r2;

            if (r1.Trim() == "" && r2.Trim() == "")
            {
                result = "";
            }
            else if (r1.Trim() == "")
            {
                result = r2;
            }
            return result;
        }
        private String ten_lakh_detail(Int32 n)
        {
            String result = "";
            Int32 ten_lakh, lakh;
            ten_lakh = n / 100000;
            lakh = n % 100000;

            String r1 = ten_thousand_detail(ten_lakh);
            String r2 = ten_thousand_detail(lakh);
            result = r1 + " lakh " + r2;

            if (r1.Trim() == "" && r2.Trim() == "")
            {
                result = "";
            }
            else if (r1.Trim() == "")
            {
                result = r2;
            }
            return result;
        }
        private String crore_detail(Int32 n)
        {
            String result = "";
            Int32 crore, ten_lakh;
            crore = n / 10000000;
            ten_lakh = n % 10000000;

            String r1 = one_to_ninteen(crore);
            String r2 = ten_thousand_detail(ten_lakh);
            result = r1 + " crore " + r2;

            if (r1.Trim() == "" && r2.Trim() == "")
            {
                result = "";
            }
            else if (r1.Trim() == "")
            {
                result = r2;
            }
            return result;
        }
        public String InWords(String val)
        {
            try
            {
                Console.WriteLine(val + "<<INPUT");
                Int32 amount = 0;
                String words = "";
                String[] amt;
                bool isdecimal = false;
                String decimal_part_temp = "";
                Int32 decimal_part = 0;
                amt = (val).Split('.');
                if (val.Trim() == "0")
                {
                    words = "";
                    return words;
                }
                else
                {
                    if (amt.Length < 2)
                    {
                        amount = Convert.ToInt32(amt[0]);
                    }
                    else
                    {
                        Console.WriteLine(amt[1]);
                        amount = Convert.ToInt32(amt[0]);
                        decimal_part_temp = amt[1];
                        isdecimal = true;
                    }
                }
                //Before Decimal
                if (amount <= 19)
                {
                    words = upto_ninteen(amount);
                }
                else if (amount <= 99)
                {
                    words = ten_details(amount);
                }
                else if (amount <= 999)
                {
                    words = hundred_detail(amount);
                }
                else if (amount <= 9999)
                {
                    words = thousand_detail(amount);
                }
                else if (amount <= 99999)
                {
                    words = ten_thousand_detail(amount);
                }
                else if (amount <= 999999)
                {
                    words = lakh_detail(amount);
                }
                else if (amount <= 9999999)
                {
                    words = ten_lakh_detail(amount);
                }
                else if (amount <= 99999999)
                {
                    words = crore_detail(amount);
                }
                //After Decimal
                String word_decimal = "";
                if (isdecimal)
                {
                    Int32 length = decimal_part_temp.ToString().Length;
                    decimal_part = Convert.ToInt32(decimal_part_temp);

                    if (decimal_part < 10 && length == 1)
                    {
                        String temp = "";
                        temp = decimal_part.ToString() + "0";
                        decimal_part = Convert.ToInt32(temp);
                    }
                    else if (decimal_part < 10 && length == 2)
                    {
                        String temp = "";
                        temp = decimal_part.ToString();
                        decimal_part = Convert.ToInt32(temp);
                    }
                    if (decimal_part <= 19)
                    {
                        word_decimal = upto_ninteen(decimal_part);
                    }
                    else if (decimal_part <= 99)
                    {
                        word_decimal = ten_details(decimal_part);
                    }
                }
                //---------------------------------------------------->
                if (word_decimal == "")
                {
                    words = words + " Rupee Only /-"; ;
                }
                else if (words == "")
                {
                    words = word_decimal + " Paisa Only /-";
                }
                else
                {
                    words = words + " Rupee and " + word_decimal + " Paisa Only /-";
                }
                words = words.ToUpper();
                return words;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "#Error-E2N-N/A";
            }
        }
    }
}
