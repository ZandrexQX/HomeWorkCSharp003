Console.Clear();
Console.WriteLine("Task 19");
Console.WriteLine("------");

Console.Write("Enter number:");
int num1 = Convert.ToInt32(Console.ReadLine());
string str1 = num1.ToString();
bool flag = true;
for (int i = 0; i < str1.Length; i++){
    if (str1[i] != str1[str1.Length-1-i]) flag = false;
}

if(flag) Console.WriteLine($"Number {num1} palindrome");
else
    Console.WriteLine($"Number {num1} not palindrome");

Console.ReadLine();

/*--------------------------------------------*/