using System;

namespace Tpyeconversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integer to char
            int c = 123;
            String str = Convert.ToString(c);
            Console.WriteLine("Integer to char: "+str+ "\n");

            //Char to Integer
            string strg = "1234";
            int val = Convert.ToInt32(strg);
            Console.WriteLine("Char to Integer: "+val+ "\n");

            //Integer to Float
            int f = 12;
            float vale = Convert.ToSingle(f);
            Console.WriteLine("Integer to Float: "+vale+ "\n");

            //Int to Double
            int value = 54;
            Double d = Convert.ToDouble(value);
            Console.WriteLine("Int to Double: "+d+ "\n");

            //Float to Double
            float fd = 1.5f;
            Double dob = Convert.ToDouble(fd);
            Console.WriteLine("Float to Double: " + dob + "\n");

            //String to boolean
            string convert  = "true";
            bool boolvalue = Convert.ToBoolean(convert);
            Console.WriteLine("String to boolean: " + boolvalue + "\n");

            //int to boolean
            int b = 0;
            bool boolean = Convert.ToBoolean(b);
            Console.WriteLine("int to boolean: " + boolean + "\n");

            //Converts a type to a byte
            string stri = "10";
            byte bytevalue = Convert.ToByte(stri);
            Console.WriteLine("string to byte: "+ bytevalue +"\n");

            //Converts type to a datatime
            DateTime dt2 = DateTime.Now;
            Console.WriteLine("update datatime: "+dt2 +"\n");

            //Converts type to a decimal
            string stringVal = "2,345.26";
            decimal.Parse(stringVal);
            Console.WriteLine("convert to decimal:"+ stringVal + "\n");


            // float to double
            float floatNum = 3.14f;
            double doubleNum = floatNum;
            Console.WriteLine("convert to double:" + doubleNum);
        }
    }
}