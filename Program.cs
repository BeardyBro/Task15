Console.WriteLine("Insert one-digit number");
int num = Convert.ToInt32(Console.ReadLine());
if (num<1 || num>7)
{
    Console.WriteLine("Doesn`t meet the requirements");
}
else if (num%7==0 || num%6==0)
{
    Console.WriteLine("Yes");
    }
            
else 
{Console.WriteLine("No");}