using P3_4;

Random random = new Random();
DTreeNode root = null;
//Задание 1
for (int i = 0; i < 10; i++)
{
    int key = random.Next(-1000, 1001);
    root = DixotomyTree.Insert_DNode(root, 1+i, key);

}

Console.WriteLine($"Сумма инвормационных полей: {DixotomyTree.Sum(root)}");
Console.WriteLine();

//Задание 2
Console.WriteLine($"Внутренние узлы дерева: {DixotomyTree.CountInternalNodes(root)}");
Console.WriteLine();

//Задание 3 
List<int> negativeValues = DixotomyTree.GetNegativeValues(root);
Console.WriteLine($"Отрицательные значения информационных полей дерева: {negativeValues.Count}");
Console.WriteLine();

foreach (var value in negativeValues)
{
    Console.Write($"{value}, ");
}
