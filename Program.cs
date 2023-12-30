//Напишите программу, которая принимает на вход
//трёхзначное число и удаляет вторую цифру этого
//числа.
//Примеры
//a = 256 => 26
//a = 891 => 81

//Console.WriteLine("Введите число");
//int num = Convert.ToInt32(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());

//if (num>99 && num<1000) // && - и выполнение обоих условий; || - выболнение одного из условий
//{
//    int num1 = num/100;
//    int num3 = num % 10;
//
//    int resault = num1*10 + num3;
//    Console.WriteLine(resault);
//}

//Напишите программу, которая принимает на вход трёхзначное
//число и возводит вторую цифру этого числа в степень, равную
//третьей цифре.
//Примеры
//487 => 8^7 = 2 097 152
//254 => 5^4 = 625
//617 => 1

int num = new Random().Next(100,1000);
Console.WriteLine(num);
int num2 = num/10 %10;
int num3 = num % 10;
int resault = 1;
for (int i = 0; i <num3; i++)
{
    resault =  resault * num2;
}
Console.WriteLine(resault);