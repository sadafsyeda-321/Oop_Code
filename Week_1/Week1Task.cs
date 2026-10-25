using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //----------------------------------

            /*Console.WriteLine("Hello World!");
            Console.ReadKey();*/

            //--------- Variable Declaration  ----------------

            /*int variable = 7;
            Console.WriteLine("Value: ");
            Console.Write(variable);
            Console.ReadLine();*/

            // string

            /*string name = "I am string";
            Console.WriteLine("String: ");
            Console.Write(name);
            Console.ReadLine();*/

            // Character

            /*char letter = 'A';
            Console.WriteLine("Character: ");
            Console.Write(letter);
            Console.ReadLine();*/

            // Float

            /*float var = 2.25F;
            Console.Write("Decimal: ");
            Console.WriteLine(var);
            Console.ReadLine();*/


            // Taking input

            /*string str;
            str = Console.ReadLine();
            Console.WriteLine("You have inputted: ");
            Console.WriteLine(str);
            Console.ReadKey();*/

            //-------------  Int taking ----------------


            /*int num = int.Parse(Console.ReadLine());
            Console.WriteLine("You have inputted: ");
            Console.WriteLine("The number is: " + num);*/

            //------------ Float --------

            /*string val;
            Console.WriteLine("Enter Floating value: ");
            val = Console.ReadLine();
            float num1 = float.Parse(val);
            Console.WriteLine("The floating point is :");
            Console.WriteLine(num1);
            Console.ReadKey();*/

            //--------------------------

            /*float length;
            float area;
            string value;
            Console.WriteLine("Enter Length: ");
            str = Console.ReadLine();
            length = int.Parse(str);
            area = length * length;
            Console.WriteLine("The area is: ");
            Console.Write(area);
            Console.ReadKey();*/


            //------------------- If 

            /*float marks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your marks: ");
            Console.WriteLine("Obtained marks are: " + marks);
            if (marks > 25)
            {
                Console.WriteLine("You are passed");
            }
            else
            {
                Console.WriteLine("You are failed");
            }
            Console.ReadKey();
        }*/

            //--------------- Example 2  ---------------

            /*int speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Your speed is: " + speed);
            if (speed > 80)
            {
                Console.WriteLine("Warning! Speed is high!");
            }
            else
            {
                Console.WriteLine("Your speed is under limit");
            }*/

            //-----------------------------

            /* int a = int.Parse(Console.ReadLine());
             Console.WriteLine("Number: " + a);
             if (a % 2 == 0)
             {
                 Console.WriteLine("Even Number");
             }
             else
             {
                 Console.WriteLine("Odd Number");
             }*/

            // ------------------------

            /*int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Age: " + age);
            if (age > 18)
            {
                Console.WriteLine("Eligible to cast vote");
            }
            else
            {
                Console.WriteLine("Not Eligible!");
            }*/

            /*float marks = float.Parse(Console.ReadLine());
            Console.WriteLine("Marks: " + marks);
            if (marks > 80)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks > 60)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks > 50)
            {
                Console.WriteLine("Grade: C");
            }

            else if (marks > 40)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Appear again");
            }*/

            // Loops (for)

            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Welcome!");
            }*/

            //-----------------

            /*int sum = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                sum = sum + n;
            }
            Console.WriteLine(sum);
            Console.ReadKey();*/

            //----------------

            /*int multiple;
            int table;
            table = int.Parse(Console.ReadLine());
            Console.WriteLine("Table: " + table);
            for (int num = 1; num <= 10; num++)
            {
                multiple = table * num;
                Console.WriteLine(table + " * " + num + " = " + multiple);
            }*/

            // -------------------

            /*int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of numbers: " + sum);*/


            //------------  

            /*int num;
            num = int.Parse(Console.ReadLine());
            for (int count = 1; count <= 15; count++)
            {
                Console.WriteLine(num);
                num = num + 2;
            }*/


            //-----------------  LAB  -------------
            //---------------  TASK 1 -----------

            /*Console.WriteLine("Hello World!");
            Console.Write("Hello World! Hello World!");
            Console.Read();*/

            //------------   Task 2  ----------------

            /*int variable = 7;
            Console.WriteLine("Value: ");
            Console.Write(variable);
            Console.ReadKey();*/

            //------------  Task 3  ----------------

            /*string variable = "I am string";
            Console.WriteLine("String: ");
            Console.Write(variable);
            Console.Read();*/

            //------------- Task 4  ----------------

            /*char variable = 'a';
            Console.WriteLine("Character: ");
            Console.WriteLine(variable);
            Console.Read();*/

            //------------- Task 5 ----------------

            /*float variable = 2.25F;
            Console.WriteLine("Deciamal value: ");
            Console.WriteLine(variable);
            Console.Read();*/

            //------------- Task 6 ----------------

            /*string str;
            str = Console.ReadLine();
            Console.WriteLine("you have inputted the value: ");
            Console.WriteLine(str);
            Console.ReadKey();*/


            //------------- Task 7  ----------------


            /*int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The number is: ");
            Console.Write(num);
            Console.Read();*/


            //------------- Task 8  ----------------

            /*float num = float.Parse(Console.ReadLine());
            Console.WriteLine("Float value: ");
            Console.Write(num);
            Console.Read();*/

            //------------- Task 9  ----------------

            /*int length = int.Parse(Console.ReadLine());
            int area;
            Console.WriteLine("Enter length: " + length);
            area = length * length;
            Console.WriteLine("Area is: ");
            Console.WriteLine(area);
            Console.Read();*/

            //--------- If Else Conditions  ----------------

            //------------- Task 10

            /*int marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Marks: " + marks);
            if (marks > 50)
            {
                Console.WriteLine("You are passed ");
            }
            else
            {
                Console.WriteLine("Try Again");
            }*/

            //------------- Task 11 ----------------

            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Welcome Sadaf! ");
            }
            Console.Read();*/

            //------------- Task 12  ----------------

            /*int num = 0;
            int sum = 0;
            or int num;
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                sum = sum + num;
                Console.WriteLine("Enter Number: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The total sum is: {0} ", sum);
            Console.Read();*/



            //------------- Task 13  ----------------

            /*int num;
            int sum = 0;
            do
            {
                Console.Write("Enter Number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            while (num != -1);
            sum = sum + 1;
            Console.WriteLine("Total Sum is: {0} ", sum);
            Console.Read();*/

            //-----------  Task 14  ----------------

            /*int[] num = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number {0}: ", i);
                num[i] = int.Parse(Console.ReadLine());
            }
            // Largest
            int largest = -1;
            for (int i = 0; i < 3; i++)
            {
                if (num[i] > largest)
                {
                    largest = num[i];
                }
            }
            Console.WriteLine("Largest is: {0}", largest);
            Console.Read();*/

            // ---------- Task 15 IMp

            /*Console.Write("Enter Lily's Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Price of Machine: ");
            int machine_price = int.Parse(Console.ReadLine());
            Console.Write("Enter Price of Toy: ");
            int toy_price = int.Parse(Console.ReadLine());
            int remaining;
            int total_amount;
            int even_money = 0;
            int even_year_money = 10;
            int odd_money = 0;
            int x = 1;
            int count = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    even_money = (even_money + (even_year_money * x));
                    x++;
                    count++;
                }
                else
                {
                    odd_money = odd_money + toy_price;
                }
            }
            even_money = (even_money - count);
            total_amount = even_money + odd_money;
            remaining = total_amount - machine_price;
            if (remaining >= 0)
            {
                Console.Write("Yes! " + remaining + "\nMoney is Sufficient.");
            }
            else
            {
                remaining = -1 * remaining;
                Console.Write("No! " + remaining + "\nMoney is Insufficient.");
            }
           */

            // ----------- Function  ----------------

            // ---------------- Task 16  ----------------

            /*Console.WriteLine("Enter 1st number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = add(num1, num2);
            Console.WriteLine("Sum is {0}", result);
            Console.Read();
        }

        static int add(int n1, int n2)
        {
            return n1 + n2;
        }*/



            //---------- File Handling  ----------------

            //------------------ Task 17   ----------------

            /*string path = "D:\\2nd Semester\\OOP\\OOP Lab\\Tasks\\textfile.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine("Hello!");
            file.Flush();
            file.Close();*/

            //------------------ Task 18   ----------------

            /*string path = "D:\\2nd Semester\\OOP\\OOP Lab\\Tasks\\textfile.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }*/


            //------------------ Task 19   ----------------

            /*static int menu()
            {
                int option;
                Console.WriteLine("1: SignIn ");
                Console.WriteLine("2: SignUp ");
                Console.WriteLine("Enter option:");
                option = int.Parse(Console.ReadLine());
                return option;
            }

            static string parseData(string record, int field)
            {
                int comma = 1;
                string item = " ";
                for (int x = 0; x < record.Length; x++)
                {
                    if (record[x] == ',')
                    {
                        comma++;
                    }
                    else if (comma == field)
                    {
                        item = item + record[x];
                    }
                }
                return item;
            }

            static void readData(string path, string[] names, string[] password)
            {
                int x = 0;
                if (File.Exists(path))
                {
                    StreamReader fileVariable = new StreamReader(path);
                    string record;
                    while ((record = fileVariable.ReadLine()) != null)
                    {
                        names[x] = parseData(record, 1);
                        password[x] = parseData(record, 2);
                        x++;
                        if (x >= 5)
                        {
                            break;
                        }
                    }
                    fileVariable.Close();
                }
                else
                {
                    Console.WriteLine("Not Exists!");
                }
            }

                static void signIn(string n, string p, string[] names, string[] password)
                {
                    bool flag = false;
                    for (int x = 0; x < 5; x++)
                    {
                        if (n == names[x] && p == password[x])
                        {
                            Console.WriteLine("Valid User"); 
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        Console.WriteLine("Invalid User");
                    }
                    Console.ReadKey();
                }


                static void signUp(string path, string n, string p)
                {
                    StreamWriter file = new StreamWriter(path, true);
                    file.WriteLine(n + "," + p);
                    file.Flush();
                    file.Close();
                }

                static void Main(string[] args)
                {
                    string path = "D:\\2nd Semester\\OOP\\OOP Lab\\Tasks\\textfile.txt";
                    string[] names = new string[5];
                    string[] password = new string[5];
                    int option;
                do
                {
                    readData(path, names, password);
                    Console.Clear();
                    option = menu();
                    Console.Clear();
                    if (option == 1)
                    {
                        Console.WriteLine("Enter Name: ");
                        string n = Console.ReadLine();
                        Console.WriteLine("Enter password: ");
                        string p = Console.ReadLine();
                        signIn(n, p, names, password);
                    }
                    else if (option == 2)
                    {
                        Console.WriteLine("Enter Name: ");
                        string n = Console.ReadLine();
                        Console.WriteLine("Enter password: ");
                        string p = Console.ReadLine();
                        signUp(path, n, p);
                    }
                }
                while (option < 3);
                            Console.Read();
                        }*/


            //----------------- Task 20 -----------------


            /*Console.Write("Enter the least amount of orders: ");
            int minOrders = int.Parse(Console.ReadLine());
            Console.Write("Enter the least amount of price: ");
            int minPrice = int.Parse(Console.ReadLine());
            string FilePath = "D:\\2nd Semester\\OOP\\OOP Lab\\Tasks\\Customers.txt";
            string[] name1 = new string[2];
            int[] orders_data = new int[2];
            string[] price_data = new string[2];
            int totalCustomers = OrdersDetails(FilePath, name1, orders_data, price_data);
            int count1 = 0;
            for (int m = 0; m < totalCustomers; m++)
            {
                string BracketremovedPrices = price_data[m].Replace("[", "").Replace("]", "");
                string[] Prices = BracketremovedPrices.Split(',');
                for (int j = 0; j < Prices.Length; j++)
                {
                    if (int.Parse(Prices[j]) >= minPrice)
                    {
                        count1++;
                    }
                }
                if (count1 >= minOrders)
                {
                    Console.WriteLine(name1[m]);
                }
            }*/
        }

        /*static string ParseDataSpace(string record1, int field1)
            {
                int space = 1;
                string item1 = "";
                for (int w = 0; w < record1.Length; w++)
                {
                    if (record1[w] == ' ')
                    {
                        space++;
                    }
                    else if (space == field1)
                    {
                        item1 = item1 + record1[w];
                    }
                }
                return item1;
            }
            static int OrdersDetails(string FilePath, string[] name, int[] orders_data, string[] price_data)
            {
                int index = 0;
                if (File.Exists(FilePath))
                {
                    StreamReader customer_file = new StreamReader(FilePath);
                    string details;
                    while ((details = customer_file.ReadLine()) != null)
                    {
                        name[index] = ParseDataSpace(details, 1);
                        orders_data[index] = int.Parse(ParseDataSpace(details, 2));
                        price_data[index] = ParseDataSpace(details, 3);
                        index++;
                    }
                    customer_file.Close();
                }
                return index;
            }*/
        }
    }


