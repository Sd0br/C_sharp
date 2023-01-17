/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
все 8 элементов должны получить за один Console.ReadLine();
подсказка: использовать потом метод string.Split();
*/

Console.Write("Введите 8 чисел через ,: ");
string mainString = Console.ReadLine();
string[] twoString = mainString.Split(",");
//Console.WriteLine(twoString.Length);
int[] newArray = new int[twoString.Length];
for (int i = 0; i < twoString.Length; i++)
{
     //Console.WriteLine(twoString[i]);
     int.TryParse(twoString[i], out newArray[i]);
}

for (int i = 0; i < twoString.Length; i++)
{
     Console.WriteLine(newArray[i]);
}
