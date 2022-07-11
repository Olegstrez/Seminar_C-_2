Console.WriteLine("Ведите число ");
int number = Convert.ToInt32(Console.ReadLine());
int n=0;
if(number>100 && number<1000)
{n=number%10;}
else if(number<10000 && number>1000)
{
    {n=number%100/10;}
}
Console.WriteLine("Третья цифра =" +n);
