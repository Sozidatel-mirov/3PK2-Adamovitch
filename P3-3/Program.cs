using P3_3;

BynaryTree tree = new BynaryTree(6);

//BynaryTree.GetTreeData(tree.Root);
Console.Write("Среднее значение:");
BynaryTree.AverageArif(tree.Root);
Console.WriteLine("Положительные числа: " + BynaryTree.CountPlus(tree.Root));
Console.WriteLine("Отрицательные числа: " + BynaryTree.CountMinus(tree.Root));

Console.Write("Введите число для поиска:");
int sverka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество вхождений вашего числа: " + BynaryTree.Countsverka(tree.Root, sverka));