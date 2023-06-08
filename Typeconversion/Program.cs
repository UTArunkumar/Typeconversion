using System;

namespace Tpyeconversion
{
    class Program
    {
        static void Main(string[] args)
        {

            //Conversion using Convert class
            Console.WriteLine("Convert method: "+"\n");
            int c = 123;
            string str = Convert.ToString(c);
            Console.WriteLine("Integer to char: " + str );

            string strg = "1234";
            int val = Convert.ToInt32(strg);
            Console.WriteLine("Char to Integer: " + val );

            int f = 12;
            float vale = Convert.ToSingle(f);
            Console.WriteLine("Integer to Float: " + vale );

            int value = 54;
            double d = Convert.ToDouble(value);
            Console.WriteLine("Int to Double: " + d  );

            float fd = 1.5f;
            double dob = Convert.ToDouble(fd);
            Console.WriteLine("Float to Double: " + dob );

            string convert = "true";
            bool boolvalue = Convert.ToBoolean(convert);
            Console.WriteLine("String to boolean: " + boolvalue );

            int b = 0;
            bool boolean = Convert.ToBoolean(b);
            Console.WriteLine("int to boolean: " + boolean );

            string stri = "10";
            byte bytevalue = Convert.ToByte(stri);
            Console.WriteLine("string to byte: " + bytevalue + "\n");


            //implisity conversion
            Console.WriteLine("Implisity method: " );

            float floatNum = 3.14f;
            double doubleNum = floatNum;
            Console.WriteLine("Float to double: "+doubleNum );

            int num = 100;
            long bigNum = num;
            Console.WriteLine("Int to long:"+bigNum);

            char st = 'A';
            int asciiValue = st;
            Console.WriteLine("Char to asciivalue: "+asciiValue);


            int nume = 10;
            double decimalNum = nume;
            Console.WriteLine("Int to double: "+decimalNum);

            byte it = 255; 
            int its = it;
            Console.WriteLine("Byte to int:"+its + "\n");


            //Explicit Conversion
            Console.WriteLine("Explicit method: " + "\n");

            double d3 = 9.622345785796;
            float f3 = (float)d3;
            Console.WriteLine("Double to float: "+f3);

            double d1 = 5.009754789999;
            int d2 = (int)d1;
            Console.WriteLine("Double to int: "+d2);

            float f1 = 4.7680f;
            int f2 = (int)f1;
            Console.WriteLine("Float to int: "+f2);

            int b3 = 245;
            byte b2 = (byte)b3;
            Console.WriteLine("Int to byte: "+ b2);

            int ch = 97;
            char ch2 = (char)ch;
            Console.WriteLine("Int to char: "+ch2+"\n");



            //parseing conversion
            Console.WriteLine("parseing method: " + "\n");

            string a = "1234";
            int b1 = int.Parse(a);
            Console.WriteLine("string to int: " + b1);

            string s1 = "7.65449554";
            double de = double.Parse(s1);
            Console.WriteLine(de);

            string stringVal = "2,345.26";
            var dd = decimal.Parse(stringVal);
            Console.WriteLine(dd.GetType());
            Console.WriteLine(decimal.MaxValue);

            string httpTime = "Fri, 27 Feb 2009 03:11:21 GMT";
            DateTime time = DateTime.Parse(httpTime);
            Console.WriteLine(time);


            //Try parse method
            string text1 = "x";
            int num1;
            bool res = int.TryParse(text1, out num1);
            if (res == false)
            {
                Console.WriteLine(num1);
            }

            string text2 = "10000";
            int num2;
            if (int.TryParse(text2, out num2))
            {
                Console.WriteLine(num2);
            }

            const string value3 = "345";
            if (int.TryParse(value3, out int result))
            {
                Console.WriteLine(result + 1);
            }
        }
    }
}
