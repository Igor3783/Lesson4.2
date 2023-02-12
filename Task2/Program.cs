// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число : ");

int num = Convert.ToInt32(Console.ReadLine());

  int sum1(int num){
    
    int count = Convert.ToString(num).Length;

    int advance = 0;

    int result = 0;

    for (int i = 0; i < count; i++){

      advance = num - num % 10;

      result = result + (num - advance);

      num = num / 10;
    }
   return result;
  }

int sum = sum1(num);

Console.WriteLine("Сумма цифр в числе: " + sum);