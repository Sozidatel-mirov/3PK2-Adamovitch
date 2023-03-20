using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P3_4
{
    public class DixotomyTree
    {
        private DTreeNode root; // ссылка на корень дихотомического дерева
        public DTreeNode Root // свойство, открывающее доступ к корню дерева
        {
            get { return root; }
            set { root = value; }
        }
        public DixotomyTree() // создание пустого дерева
        {
            root = null;
        }
        public static DTreeNode Insert_DNode(DTreeNode root, int k, int a)
        {
            if (root == null)
            {
                return new DTreeNode(k, a);
            }
            else
            {
                if (k < root.Key)
                    root.Left = Insert_DNode(root.Left, k, a);
                else if (k > root.Key)
                    root.Right = Insert_DNode(root.Right, k, a);
                else
                    Console.WriteLine($"узел с ключом {k} уже есть в дереве");
            }
            return root;
        }

        public static int Sum(DTreeNode node)
        {
            if (node == null)
                return 0;
            return node.Key + Sum(node.Left) + Sum(node.Right);//сумма ключа текущего узла
        }
        public static int CountInternalNodes(DTreeNode node)
        {
            if (node == null)
                return 0;
            else if (node.Left == null && node.Right == null)
                return 0;
            else
                return 1 + CountInternalNodes(node.Left) + CountInternalNodes(node.Right);

        }
        public static List<int> GetNegativeValues(DTreeNode node)//Поиск отрицательных значений
        {

            List<int> result = new List<int>();

            if (node == null)
                return result;


            if (node.Key < 0) // Проверка отрицательности
            {
                result.Add(node.Key);
                Console.WriteLine($"Узел: {node.Info}, Отрицательное: {result.Count}: {node.Key} ");

            }
            else
            {
                Console.WriteLine($"Узел: {node.Info}, Отрицательное: {result.Count}: {node.Key} ");

            }

            result.AddRange(GetNegativeValues(node.Left));
            result.AddRange(GetNegativeValues(node.Right));

            return result;
        }

    }
}
