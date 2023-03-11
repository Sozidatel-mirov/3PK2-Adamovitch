using P3_4;

DixotomyTree dixotomyTree= new DixotomyTree();
dixotomyTree.Insert_DNode(dixotomyTree.Root, 4);
dixotomyTree.Insert_DNode(dixotomyTree.Root, 5);
dixotomyTree.Insert_DNode(dixotomyTree.Root, 2);
dixotomyTree.Insert_DNode(dixotomyTree.Root, 4);
dixotomyTree.Insert_DNode(dixotomyTree.Root, -12);

DixotomyTree.GetTreeData(dixotomyTree.Root);
