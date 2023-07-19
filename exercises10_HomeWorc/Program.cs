/*
შექმენით enum სახელწოდებით "DaysOfWeek", რომელიც წარმოადგენს კვირის დღეებს (კვირა, ორშაბათი, სამშაბათი და ა.შ.). 
დაწერეთ პროგრამა, რომელიც სთხოვს მომხმარებელს შეიყვანოს რიცხვი 1-დან 7-მდე და აჩვენებს კვირის შესაბამის დღეს ნომრის გამოყენებით.
შექმენით enum სახელწოდებით "Status", რომელშიც გექნებათ შემდეგი კონსტანტები : "Sent, Delivered, Deleted",
Program.cs ში შექმენით ცვლადი და მიანიჭეთ რომელიმე სტატუსი, switch statement ში, შეადერეთ ეს ცვლადი enum ის თითოეულ
ელემენტს და გამოიტანეთ შესაბამისი შეტყობინებები.შექმენით Person კლასი, რომელსაც ექნება Name და სტატიკური წევრი count, 
Person კლასის ახალი ინსტანსის შექმნის დროს უნდა ხდებოდეს count ის 1 ით გაზრდა, დაბეჭდეთ count ის მნიშვნელობა.*/

using exercises10_HomeWorc;
using System.Reflection.Emit;

Console.WriteLine("Enter numbers up to 7");
int weekdays = int.Parse(Console.ReadLine());
if (weekdays == 1)

{
    Console.WriteLine("Monday");
}
else if (weekdays == 2)
{
    Console.WriteLine("Tuesday");
}
else if (weekdays == 3)
{
    Console.WriteLine("Wednesday");
}
else if (weekdays == 4)
{
    Console.WriteLine("Thursday");
}
else if (weekdays == 5)
{
    Console.WriteLine("Friday");
}
else if (weekdays == 6)
{
    Console.WriteLine("Saturday");
}
else if (weekdays == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("This day does not exist");
}



{
    Status myVar = Status.Sent;
    switch (myVar)
    {
        case Status.Sent:
            Console.WriteLine("Sent call");
            break;
        case Status.Delivered:
            Console.WriteLine("Delivered call");
            break;
        case Status.Delete:
            Console.WriteLine("Delete call");
            break;
    }
}



Person person = new Person();

 Person obj1 = new Person();
 Person obj2=new Person();
 Person obj3=new Person();
 Person obj4=new Person();
 Person obj5=new Person();
 Person obj6=new Person();
 Console.WriteLine(Person.count);


