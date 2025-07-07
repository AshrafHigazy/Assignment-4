namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number
            //Console.Write("Enter number to print numbers between 1 -> number : ");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);

            //if (flag)
            //{
            //    if (number > 1)
            //    {
            //        for (int i = 2; i < number; i++)
            //        {
            //            Console.Write(i + " ");
            //        }
            //    }
            //    else { Console.WriteLine("The number less than 1 !"); }
            //}else { Console.WriteLine("Invalid input"); }

            #endregion
            #region 7- Write a program that allows the user to insert an integer then  print a multiplication table up to 12.
            //Console.Write("Enter number to print multiplication table up to 12 : ");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);

            //if (flag)
            //{
            //        for (int i = 1; i <= 12; i++)
            //        {
            //            Console.Write(i*number + " ");
            //        }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            #endregion
            #region 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter number to print even numbers between 1 -> number : ");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);

            //if (flag)
            //{
            //    if (number > 1)
            //    {
            //        for (int i = 2; i <= number; i++)
            //        {
            //            if (i % 2 == 0)
            //            {
            //                Console.Write(i  + " ");

            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number less than 1 !");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            #endregion
            #region 9- Write a program that takes two integers then prints the power
            //Console.Write("Enter number to print the power : ");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int number);
            //Console.Write("Enter the power : ");
            //bool flag2 = int.TryParse(Console.ReadLine(), out int power);
            //if (flag1&&flag2)
            //{
            //    long result = 1;
            //        for (int i = 1; i <= power; i++)
            //        {
            //        result = result * number; 
            //        }
            //    Console.Write(result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            #endregion
            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage
            //Console.Write("Enter the number of  subjects: ");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int size);



            //if (flag1 && size > 0)
            //{
            //    int[] arr = new int[size];

            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Marks of  subject {i + 1}: ");

            //        while (!int.TryParse(Console.ReadLine(), out arr[i]))
            //        {
            //            Console.Write("Invalid input. Enter an integer: ");
            //        }
            //    }
            //    //total
            //    int total = 0;
            //    for (int i = 0; i < size; i++)
            //    {
            //        total += arr[i];
            //    }
            //    Console.WriteLine($"Total Marks ={total}");
            //    //average
            //    double avg = total / size;
            //    Console.WriteLine($"Average Marks = {avg}");
            //    //Percentage 
            //    double precent = avg;
            //    Console.WriteLine($"Percentage  Marks = {precent}%");
            //}
            //else
            //{
            //    Console.WriteLine("Integer only.!!");
            //}
            #endregion
            #region 11- Write a program to input the month number and print the number of days in that month.
            //Console.Write("Enter number of mounth : ");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);

            //by if statement

            //if (flag)
            //{
            //    if (number == 1 || number == 3 || number==5 || number == 7 || number == 8 || number == 10 || number == 12)
            //    {
            //        Console.WriteLine("Days in Month: 31");
            //    }
            //    else if(number == 4 || number == 6 || number == 9 || number == 11)
            //    {
            //        Console.WriteLine("Days in Month: 30");
            //    }
            //    else if (number == 2)
            //    {
            //        Console.WriteLine("Days in Month: 28");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid mounth..!!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("invalid input!!");
            //}

            //by switch statement

            //switch (number)
            //{
            //    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 4: case 6: case 9: case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month: 28");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid mounth..!!");
            //        break;
            //} 
            #endregion
            #region 12- Write a program to create a Simple Calculator.
            //int num1, num2, operation;
            //bool flag1, flag2, flag3;
            //do
            //{
            //    Console.Write("Enter Number one : ");
            //    flag1 = int.TryParse(Console.ReadLine(), out num1);
            //    Console.Write("Enter Number Two : ");
            //    flag2 = int.TryParse(Console.ReadLine(), out num2);
            //    Console.Write("Choose The opretion: \n" +
            //    "1) +\n" +
            //    "2) -\n" +
            //    "3) *\n" +
            //    "4) /\n" +
            //    "5) %\n" +
            //    "...");
            //    flag3 = int.TryParse(Console.ReadLine(), out operation);

            //    if (flag1 && flag2 && flag3)
            //    {

            //        double result;

            //        switch (operation)
            //        {
            //            case 1:
            //                result = num1 + num2;
            //                Console.WriteLine($"{num1} + {num2} = {result}");
            //                break;
            //            case 2:
            //                result = num1 - num2;
            //                Console.WriteLine($"{num1} - {num2} = {result}");
            //                break;
            //            case 3:
            //                result = num1 * num2;
            //                Console.WriteLine($"{num1} * {num2} = {result}");
            //                break;
            //            case 4:
            //                if (num2 > 0)
            //                {
            //                    result =(double) num1 / num2;
            //                    Console.WriteLine($"{num1} / {num2} = {result}");
            //                }
            //                else { Console.WriteLine("Error:: Denominator can not be zero.!!"); }
            //                    break;
            //            case 5:
            //                result = num1 % num2;
            //                Console.WriteLine($"{num1} mod {num2} = {result}");
            //                break;
            //            default:
            //                Console.WriteLine("Indvalid operation.!!");
            //                break;
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter intager only");
            //    }
            //    Console.WriteLine("If you wont: \n -Do another operation press(a) : \n -Stop press any key.!");
            //    string c=Console.ReadLine();
            //    if(c.ToLower() != "a")
            //    {
            //        break;
            //    }
            //} while (true);
            #endregion
            #region 13- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter String to reverse it : ");
            //string c=Console.ReadLine();

            //string rev = ""; 
            //for(int i = c.Length-1; i >= 0; i--)
            //{
            //    rev += c[i];
            //}
            //Console.Write($"Reversed: {rev}");
            #endregion
            #region 14- Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("Enter number to reverse it : ");
            //bool flag = int.TryParse(Console.ReadLine(),out int num);
            //if (flag)
            //{
            //    string reverse="";
            //    string s =Math.Abs(num).ToString();
            //    for(int i = s.Length-1; i >= 0; i--)
            //    {
            //        reverse += s[i];
            //    }
            //    if (num < 0)
            //    {
            //        Console.WriteLine($"Reversed: -{reverse}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Reversed: {reverse}");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Enter integer only..!");
            //}
            #endregion
            #region 15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            Console.Write("Enter number to find prime number ( from 1 to your number ) : ");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if(flag && number > 1)
            //{
            //    for(int i = 2; i <= number; i++)
            //    {
            //        bool prime = true;
            //        for(int j = 2; j <= i / 2; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                prime = false;
            //                break;
            //            }
            //        }
            //        if (prime)
            //        {
            //            Console.Write(i + " ");
            //        }
            //    }
            //}
            //else { Console.WriteLine(" Please enter numbers grater than ( 1 ) "); }
            #endregion
            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Enter 3 Points: \n" +
            //    "(x1, y1)=");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int x1);
            //bool flag2 = int.TryParse(Console.ReadLine(), out int y1);
            //Console.WriteLine("(x2, y2)=");
            //bool flag3 = int.TryParse(Console.ReadLine(), out int x2);
            //bool flag4 = int.TryParse(Console.ReadLine(), out int y2);
            //Console.WriteLine("(x3, y3)=");
            //bool flag5 = int.TryParse(Console.ReadLine(), out int x3);
            //bool flag6 = int.TryParse(Console.ReadLine(), out int y3);
            //if (flag1 && flag2 && flag3 && flag4 && flag5 && flag6)
            //{

            //    if (x1 == x2 && x1 == x3)
            //    {
            //        Console.WriteLine("Pointes are Vertical line ");
            //    }
            //    else if (x1 == x2 || x1 == x3)
            //    {
            //        Console.WriteLine("Can not devide on zero , Two points are Vertical..!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("----------( Find the Slop )----------");
            //        double m1, m2;
            //          m1 = (y2 - y1) / (x2 - x1);
            //          Console.WriteLine($"m1 = ({y1} - {y2}) / ({x1} - {x2}) = {m1}");
            //          m2 = (y3 - y1) / (x3 - x1);
            //          Console.WriteLine($"m2 = ({y1} - {y3}) / ({x1} - {x3}) = {m2}");
            //        if (Math.Abs(m1 - m2) < 1e-6)
            //        {
            //            Console.WriteLine($"\nBecouse m1 = m2 = {m1} so -> Points are on straight line");
            //            Console.WriteLine("\n----------( Find the constiant )----------");
            //            double c = y1 - (m1 * x1);
            //            Console.WriteLine($"By using any slop -> c = {y1} - ({m1} * {x1}) = {c}");
            //            Console.WriteLine("\n----------( Equation of straight line )----------");
            //            Console.WriteLine($"y = {m1}x + {c}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Points does not on straight line.!");
            //        }
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Enter integer only..!");
            //}
            #endregion
            #region 18- Within a company, the efficiency of workers is evaluated 
            //Console.Write("Enter range of the time taken for the task : ");
            //bool flag = double.TryParse(Console.ReadLine(),out double time);
            //if (flag)
            //{
            //    if (time >= 2 && time <= 3)
            //    {
            //        Console.WriteLine("You are highly efficient employee , Thank you for your loyal");
            //    }
            //    else if (time > 3 && time <= 4)
            //    {
            //        Console.WriteLine("you are need to increase your speed");
            //    }
            //    else if (time > 4 && time <= 5)
            //    {
            //        Console.WriteLine("you are need trianing to increase your speed");
            //    }
            //    else if (time > 5)
            //    {
            //        Console.WriteLine("Leve the company..!");
            //    }
            //    else if (time < 2)
            //    {
            //        Console.WriteLine("The number is not in evaluation range..!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Enter numbers only.!");

            //}
            #endregion
        }
    }
}
