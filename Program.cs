﻿// Дано натуральное трёхзначное число. Создайте массив, состоящий из 
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м и тд. 
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

Console.WriteLine("Введите трёхзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];

for (int i = 0; i < 3; i++) // 
{
    array[i] = number % 10; // получили последнее число (6)
    number = number / 10; // получили второе число (45)
    // и повторно заходим в цикл до того, пока не получим 4 
}
for (int i = 0; i < array.Length; i++) // вывод новго массива, array.Length уже привязана к длине новго массива
{
    Console.Write(array[i] + " ");
}