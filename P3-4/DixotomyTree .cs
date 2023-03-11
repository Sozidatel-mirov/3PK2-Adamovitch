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
        public DTreeNode Insert_DNode(DTreeNode root, int k)
        {
            if (root == null)
            {//создание корня дерева
                root = new DTreeNode(' ', k, null, null);
            }
            else //дерево не пусто - продолжить поиск элемента с ключом
            {
                if (k < root.Key) //поиск в левом поддереве
                    root.Left = Insert_DNode(root.Left, k);
                else if (k > root.Key)//поиск в правом поддереве
                    root.Right = Insert_DNode(root.Right, k);
                else //ключ дб уникальным
                    Console.WriteLine($"узел с ключом {k} уже есть в дереве");
            }
            return root;
        }
        
        public static void GetTreeData(DTreeNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Key);
                GetTreeData(root.Left);
                GetTreeData(root.Right);
            }
        }

    }
}
