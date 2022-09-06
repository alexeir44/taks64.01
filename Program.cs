Console.Write("Enter the number n: ");
int number = int.Parse(Console.ReadLine() ?? "");
int start = 1;
PrintNumber(number,start);

void PrintNumber(int n, int start)
{
    if (start == n+ 1) return;
    if (start == n)
    {
        Console.Write(start + ".");
    }
    else
        Console.Write(start + ",");

PrintNumber(n, start + 1);
}
    


