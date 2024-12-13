// Калькулятор заложенных средств под процентную ставку
DateTime dateTime = DateTime.Now;

Console.WriteLine("Введите кол-во средств, которое вы собираетесь заложить: ");
int money = int.Parse(Console.ReadLine());
Console.WriteLine("Введите годовую ставку, под который вы закладываете деньги: ");
double procent = double.Parse(Console.ReadLine());
Console.WriteLine("Введите на сколько вы закладываете деньги (в месяцах просто цифрой): ");
int moneylong  = int.Parse(Console.ReadLine());

var result = (money * ((procent / 12 ) / 100)) * moneylong ;
Console.WriteLine($"Ваша прибыль за {moneylong} месяцев: {result}");

for (int i = 0; i < 12; i++)
{
    double mathprofit = money + Math.Round(money * ((procent / 12) / 100)) * i;
    Console.WriteLine($"Ваша прибыль за {i} месяц {dateTime.AddMonths(i)} = {Math.Round(money * ((procent / 12 ) / 100)) * i}. Общий баланс: {mathprofit}");
    
}
