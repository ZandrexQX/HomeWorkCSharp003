// Console.Clear();
// Console.WriteLine("Task 19");
// Console.WriteLine("------");

// Console.Write("Enter number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// string str1 = num1.ToString();
// bool flag = true;
// for (int i = 0; i < str1.Length; i++){
//     if (str1[i] != str1[str1.Length-1-i]) flag = false;
// }

// if(flag) Console.WriteLine($"Number {num1} palindrome");
// else
//     Console.WriteLine($"Number {num1} not palindrome");

// Console.ReadLine();

// /*--------------------------------------------*/

// Console.Clear();
// Console.WriteLine("Task 21");
// Console.WriteLine("------");

// Console.Write("Enter X1:");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter Y1:");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter Z1:");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter X2:");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter Y2:");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter Z2:");
// double z2 = Convert.ToDouble(Console.ReadLine());

// double length = Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2)+Math.Pow(z1-z2, 2));

// Console.WriteLine($"Length: {Math.Round(length,2)}");

// Console.ReadLine();

/*--------------------------------------------*/

Console.Clear();
Console.WriteLine("Task 23");
Console.WriteLine("------");

Console.Write("Enter number:");
int num2 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num2; i++) Console.Write($"{Math.Pow(i, 3)}  ");

Console.ReadLine();