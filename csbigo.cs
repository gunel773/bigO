//iki ededin ceminin yoxlanmasi
Console.WriteLine("ededleri daxil edin:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int count = 0;
int result = a + b;
while (result > 0)
{
    result /= 10;
    count++;
}
if (count == 2)
{
    Console.WriteLine("ededlerin cemi ikireqemlidir");
} 
else if(count == 3)
{
    Console.WriteLine("ededlerin cemi ucreqemlidir");
}
else
{
    Console.WriteLine("cem nezere alinmir");
}