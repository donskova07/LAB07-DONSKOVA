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


