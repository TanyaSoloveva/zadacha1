///Задайте одномерный массив из 10 целых чисел от 1 до 100. 
///Найдите количество элементов массива, значения которых лежат в отрезке [20,90]


int size = 10;
int[] myArray = new int[size];
Random rand = new Random();
for (int i = 0; i < size; i++)
myArray[i] = rand.Next(1, 101);
for (int i = 0; i < size; i++)
System.Console.Write(myArray[i] + " ");

int count = 0;
for (int i = 0; i < size; i++)
{
    if (myArray[i] > 20 && myArray[i] < 91)
        count++;
}
System.Console.WriteLine();
System.Console.WriteLine(count);