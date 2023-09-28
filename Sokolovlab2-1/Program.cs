Console.WriteLine("Введите k");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Введите j");
int j = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine(((k == 0) && (j > m))||((k < 0) && (2 * j - 3 * n) < m));