// See https://aka.ms/new-console-template for more information
Console.WriteLine("how old are you");
int age = Convert.ToInt32(Console.ReadLine());

if (age > 18)
{
    Console.WriteLine("You are eligible to vote ");
}
else
{
    Console.WriteLine("You are not old enough");
}

Console.WriteLine("how tall are you in cm");
int height = Convert.ToInt32(Console.ReadLine());

if (height<=147)
{
    Console.WriteLine("You are a dwarf ");
}
else
{
    Console.WriteLine("You are normal");
}
Console.WriteLine("MAth grade");
int math = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("phy grade");
int phy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("chem grade");
int chem = Convert.ToInt32(Console.ReadLine());

if (math + phy + chem >= 140)
{ 
    Console.WriteLine("You are eligible for the admission");
}
else
{
    Console.WriteLine("You are not eligible for the admission");
}

Console.WriteLine("Temp");
int temp = Convert.ToInt32(Console.ReadLine());

if(temp<0)
{
    Console.WriteLine("It is frezzing");
}
else if(temp>=0&& temp<=10)
{
    Console.WriteLine("It is very cold");
}
else if (temp > 10 && temp <= 20)
{
    Console.WriteLine("It is cold");
}
else if (temp > 20 && temp <= 30)
{
    Console.WriteLine("It is normal");
}
else if (temp >30 && temp <= 40)
{
    Console.WriteLine("It is hot");
}
else if (temp > 40)
{
    Console.WriteLine("It is very hot");
}

Console.WriteLine("Write a letter");
string let = Convert.ToString(Console.ReadLine());

if(let!="a"|| let != "e" || let != "i" || let != "o" || let != "u")
{
    Console.WriteLine("It is a consonant");
}
else
{
    Console.WriteLine("It is a vowel");
}

Console.WriteLine("profit");
int loss = Convert.ToInt32(Console.ReadLine());
int prof = Convert.ToInt32(Console.ReadLine());
if(prof>loss)
{
    Console.Write("Your profit was ");

    int  res= prof - loss;
    Console.WriteLine(res);
}
else
{
    Console.Write("Your loss was -");

    int res = loss-prof;
    Console.WriteLine(res);
}

Console.WriteLine("moth");
int moth = Convert.ToInt32(Console.ReadLine());
switch (moth)
{
    case 1:
        Console.WriteLine("Janeiro");
        break;
    case 3:
        Console.WriteLine("Março");
        break;
    case 5:
        Console.WriteLine("Maio");
        break;
    case 7:
        Console.WriteLine("Julho");
        break;
    case 8:
        Console.WriteLine("Agosto");
        break;
    case 10:
        Console.WriteLine("Outobro");
        break;
    case 12:
        Console.WriteLine("Dezembro");
        break;
    case 4:
        Console.WriteLine("Abril");
        break;
    case 6:
        Console.WriteLine("Junho");
        break;
    case 9:
        Console.WriteLine("Setembro");
        break;
    case 11:
        Console.WriteLine("Novembro");
        break;
    case 2:
        Console.WriteLine("Fevereiro");
        break;
    default:
        break;
}

switch (moth)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12: 
        Console.WriteLine("tem 31 dias");
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("tem 30 dias");
        break;
    case 2:
        Console.WriteLine("tem 28/29 dias");
        break;
    default:
        break;
}

Console.WriteLine("conta");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1%2==0 || num1%3==0 && num2% 2==0 || num2%3==0)
{
    int res = num1*num2;
    Console.WriteLine(res);
}
else
{
    int res = num1+num2;
    Console.WriteLine(res);
}

Console.WriteLine("Indique um ano");
int ano = Convert.ToInt32(Console.ReadLine());
if(ano%4 == 0)
{
    Console.WriteLine("It is a leap year");
}
else
{
    Console.WriteLine("It is not a leap year");
}