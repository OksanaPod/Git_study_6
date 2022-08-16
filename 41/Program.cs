Console.Write("Введите сколько чисел проверяем =");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[M];
int s = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > 0) { s = s+1; }
}
Console.WriteLine("\n Чисела больше 0 = {0}", s);