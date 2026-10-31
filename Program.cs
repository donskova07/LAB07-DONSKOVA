//задание 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
// // Выводим в обратном порядке
// for (int i = days.Length - 1; i >= 0; i--) {
//     Console.WriteLine($"{i}: {days[i]}");
// }
// задание 1.2
// double[] temps = { -5.5, -2.3, 0.0, 3.2, 5.1, 2.8, -1.4 };
// foreach (double temp in temps) {
//     Console.Write(temp + " ");
// }
// задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int doroje100 = 0;
// foreach (int price in prices) {
//      sum += price;
//      if (price > 100) doroje100++;
//  }
//  double average = (double)sum / prices.Length;
//  Console.WriteLine($"сумма: {sum}");
//  Console.WriteLine($"средняя цена: {average}");
//  Console.WriteLine($"дороже 100: {doroje100}");
//  задание 3
// int minPrice = prices[0];
// int maxIndex = 0;
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < minPrice)
//         minPrice = prices[i];
    
//     if (prices[i] > prices[maxIndex])
//         maxIndex = i;
// }
// Console.WriteLine($"минимальная: {minPrice}");
// Console.WriteLine($"самая дорогая: {maxIndex}");
// задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//         balance[i] = 0;
// }
// foreach (int b in balance)
// {
//     Console.Write(b + " ");
// }
// Console.WriteLine();
// задание 5
// int[] num = new int[5];
// for (int i = 0; i < num.Length; i++) {
//     Console.Write($"число {i+1}: ");
//     num[i] = int.Parse(Console.ReadLine());
// }
// Console.Write("обратный: ");
// for (int i = num.Length - 1; i >= 0; i--) {
//     Console.Write($"{num[i]} ");
// }
// Console.WriteLine();
// int c = 0;
// foreach (int n in num) {
//     if (n % 2 == 0) c++;
// }
// Console.WriteLine($"четные: {c}");
// задание 6
// string[] names = { "анна", "игорь", "мария", "олег", "ольга" };
// Console.Write("имя: ");
// string name = Console.ReadLine();
// int poz = -1;
// for (int i = 0; i < names.Length; i++) {
//     if (names[i] == name) {
//         poz = i;
//         break;
//     }
// }
// if (poz != -1) {
//     Console.WriteLine($"позиция {poz}");
// } else {
//     Console.WriteLine("не найдено");
// }
// фин задание
// int[] grades = { 5, 4, 3, 5, 4, 2, 5, 4 }; 
// Console.Write("оценки: ");
// foreach (int grade in grades)
//          {
// Console.Write($"{grade} ");
//          }
// Console.WriteLine();
// int vse = 0;
// int bol = grades[0];
// int men = grades[0];
// int two = 0;
// int five = 0;
//          foreach (int g in grades)
//          {
// vse += g;
// if (g > bol) bol = g;
// if (g < men) men = g;
// if (g == 2) two++;
// if (g == 5) five++;
//          }
// double sred = (double) vse / grades.Length;
// double sred1 = (int)(sred * 100 + 0.5) / 100.0;
// Console.WriteLine($"средняя: {sred1}"); 
// Console.WriteLine($"макс: {bol}, наимен: {men}");
// Console.WriteLine($"двойки: {two}, пятёрки: {five}");
// if (sred >= 4.5)
//     Console.WriteLine("отличник");
// else if (sred >= 3.5)
//     Console.WriteLine("хорошист");
// else
//     Console.WriteLine("есть над чем поработать");
// Console.WriteLine();
// доп задание
int[] arr = { 1, 2, 3, 4, 5, 6 };
foreach (int b in arr) Console.Write($"{b} ");
Console.WriteLine();
for (int i = 0; i < arr.Length / 2; i++)
        {
int a = arr[i];
arr[i] = arr[arr.Length - 1 - i];
arr[arr.Length - 1 - i] = a;
        }
Console.Write("после: ");
foreach (int b in arr) Console.Write($"{b} ");
Console.WriteLine();
