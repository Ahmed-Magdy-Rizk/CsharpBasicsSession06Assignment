namespace Session06Assignment
{
    internal class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static int SumOfDigits(int number)
        {
            string StringNumber = number.ToString();
            int sum = 0;
            for (int i = 0; i < StringNumber.Length; i++)
            {
                int digit = int.Parse(StringNumber[i].ToString());
                sum += digit;
            }
            return sum;
        }
        
        static bool IsPrime(int number)
        {
            return number % 2 == 0;
        }

        static void MinMaxArray(ref int[] arr, out int max, out int min)
        {
            if (arr is not null)
            {
                max = arr[0];
                min = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
            }
            else
            {
                max = 0;
                min = 0;
            }    
        }

        static int factorial(int number)
        {
            int result = 1;
            for (int i = number; i > 0; i--)
            {
                result += result * (i - 1);
            }
            return result;
        }

        static void ModifyByValue(int[] arr, int index, int value)
        {
            if (arr is not null)
            {
                arr[index] = value;
            }
        }
        static void ModifyByRef(ref int[] arr, int index, int value)
        {
            if (arr is not null)
            {
                arr[index] = value;
            }
        }

        static void SumSub(int x, int y, out int summation, out int subtracting)
        {
            summation = x + y;
            subtracting = x - y;
        }

        static string ChangeChar(string text, char c, int index)
        {
            if (index > 0 || index <= text.Length)
            {
                char[] chars = text.ToCharArray();
                chars[index] = c;
                
                string UbatedText = new string(chars);
                return UbatedText;
            }
            return text;
        }
        enum WeekDays
        {
            Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
        }
        enum Season
        {
            Spring, Summer, Autumn, Winter
        }

        [Flags]
        enum Permissions
        {
            Read = 1, write = 2, Delete = 4, Execute = 8
        }
        enum Colors
        {
            Red, Green, Blue
        }

        static void Main(string[] args)
        {
            /*Part 1*/
            #region Q1
            // Explain the difference between passing (Value type parameters) by value and by reference
            // then write a suitable c# example

            //// passing by value:
            ///*when we pass a value type by value, a copy of the value will passed to the method (not the acutall value)
            //so if we changed the the value of the param of method it will not affect the original var.*/

            //// in this example we will try to swap the value of x & y by just passing the value of the x & y.
            //int x = 10;
            //int y = 20;

            //Console.WriteLine("Before swap");
            //Console.WriteLine($"x: {x}");
            //Console.WriteLine($"y: {y}");

            //Swap(ref x, ref y);

            //Console.WriteLine("After swap (using passing by value)");
            //Console.WriteLine($"x: {x}");
            //Console.WriteLine($"y: {y}");


            //// passing by ref:
            ///*when we pass a value type by ref, the address of the value will passed to the method (the acutall value)
            //so if we changed the the value of the param of method it will  affect the original var.*/

            //// in this example we will try to swap the value of x & y by passing the ref of the x & y.
            //x = 10;
            //y = 20;

            //Console.WriteLine("Before swap");
            //Console.WriteLine($"x: {x}");
            //Console.WriteLine($"y: {y}");

            //Swap(ref x, ref y);

            //Console.WriteLine("After swap (using passing by ref)");
            //Console.WriteLine($"x: {x}");
            //Console.WriteLine($"y: {y}");
            #endregion
            #region Q2
            // 2.Write a program in C# Sharp to create a function to calculate the sum of the individual digits
            // of a given number.
            //Console.WriteLine(SumOfDigits(101));
            #endregion
            #region Q3
            // 3.Create a function named "IsPrime", which receives an integer number
            // and retuns true if it is prime, or false if it is not:
            //Console.WriteLine(IsPrime(4));
            #endregion
            #region Q4
            //4.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array
            //, using reference parameters
            //int[] ints = { 1, 9, 3, 10, 5, -6, 7, 8, 9 };
            //int max, min;
            //MinMaxArray(ref ints, out max, out min);
            //Console.WriteLine($"Max Value: {max}");
            //Console.WriteLine($"Min Value: {min}");
            #endregion
            #region Q5
            // 5.Create an iterative (non-recursive) function
            // to calculate the factorial of the number specified as parameter
            //Console.WriteLine(factorial(5));
            #endregion
            #region Q6
            // 6.Explain the difference between passing (Reference type parameters)
            //by value and by reference then write a suitable c# example

            // passing by value:
            /*when we pass a ref type by value, a copy of the ref will passed to the method,
            (stack now have to ref pointing to the same object)
            so if we changed the the value of the param of method it will affect the original object.*/

            // passing by ref:
            /*when we pass a ref type by ref, the ref itself will passed to the method,
            (stack now have only one ref pointing to the object)
            so if we changed the the value of the param of method it will also affect the original object.*/


            // in this example we will pass an array (firstly by value and second time by ref) and we try to change the value of the first element
            // within the method
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine($"Before ModifyByValue: {arr[3]}");
            //ModifyByValue(arr, 3, 30);
            //Console.WriteLine($"After ModifyByValue: {arr[3]}");

            //Console.WriteLine($"Before ModifyByRef: {arr[3]}");
            //ModifyByRef(ref arr, 3, 300);
            //Console.WriteLine($"After ModifyByRef: {arr[3]}");

            #endregion
            #region Q7
            // Write a c# Function that accept 4 parameters from user
            // and return result of summation and subtracting of two numbers
            //int summation, subtracting;
            //SumSub(10, 5, out summation, out subtracting);
            //Console.WriteLine($"summation: {summation}");
            //Console.WriteLine($"subtracting: {subtracting}");
            #endregion
            #region Q8
            // 8. Create a function named "ChangeChar" to modify a letter in a certain position
            // (0 based) of a string, replacing it with a different letter
            //string Mystring = "My name is Mahdy";
            //string UbdatedName = ChangeChar(Mystring, 'g', 13);
            //Console.WriteLine(UbdatedName);
            #endregion
            /*Part 2*/
            #region Q1
            // 1-	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            // Then, write a C# program that prints out all the days of the week using this enum
            //Console.WriteLine(typeof(WeekDays));
            //for (int i = 0; i < Enum.GetValues(typeof(WeekDays)).Length; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}
            #endregion
            #region Q2
            // 2.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            // Write a C# program that takes a season name as input from the user and displays the corresponding
            // month range for that season. Note range for seasons ( spring march to may , summer june to august
            // , autumn September to November , winter December to February)

            //Console.WriteLine("Please enter your season: ");
            //string UserInput = Console.ReadLine();


            //if(Enum.TryParse<Season>(UserInput, true, out Season UserSeason))
            //{
            //    switch (UserSeason)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("march to may");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("june to august");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid input");
            //            break;
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion
            #region Q4
            // 4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            // Create Variable from previous Enum to Add and Remove Permission from variable,
            // check if specific Permission is existed inside variable

            //// Create Variable from previous Enum
            //Permissions MyPermissions;

            //// Add Permission (Read, write, Delete)
            //MyPermissions = (Permissions)7;

            //// print out permissions
            //Console.WriteLine($"MyPermissions: {MyPermissions}");

            //// Remove permission
            //MyPermissions &= ~Permissions.write;
            //Console.WriteLine($"MyPermissions after removing write: {MyPermissions}");

            //// check if specific Permission is existed inside variable
            //if ((MyPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine($"Read Permission existed");
            //}
            //else
            //{
            //    Console.WriteLine($"Read Permission not existed");
            //}
            #endregion
            #region
            // 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            // Write a C# program that takes a color name as input from the user and displays a message
            // indicating whether the input color is a primary color or not.

            //Console.WriteLine("Please enter your color: ");
            //string UserInput = Console.ReadLine();


            //if (Enum.TryParse<Colors>(UserInput, true, out Colors UserColor))
            //{
            //    Console.WriteLine($"{UserColor} is a primary color");
            //}
            //else
            //{
            //    Console.WriteLine($"{UserColor} is not a primary color");
            //}
            #endregion
        }
    }
}
