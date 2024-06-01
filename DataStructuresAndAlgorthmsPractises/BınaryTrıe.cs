// Binary Tree 
// çok önemli bir arama algoirtması 1 milyonda 30 aramayla bulunabiliyor.
// bir node en fazla 2 ye ayrılır
// örneğin 3 geldi 8 den büyükmü değilse sola git
//recursive  olay sürekli karşılaştırıyor kendisinden küçükse sola büyükse sağa


// 8
// 3      10
//1    6       14
//4   7   13

//yazdırmak için orta node dan başlanır sola gidilir left boş değilse yine sola en sola gidilir çıktı şu şekilde : 1 3 4 6 7 8 10 13 14 

//Node rootNode = new Node(8);
//AddNode(rootNode, 3);
//AddNode(rootNode, 10);
//AddNode(rootNode, 6);
//AddNode(rootNode, 1);
//AddNode(rootNode, 4);
//AddNode(rootNode, 7);
//AddNode(rootNode, 14);
//Traverse(rootNode);

//Console.ReadLine();
//void AddNode(Node rootNode, int val)
//{


//    if (rootNode.Val > val)
//    {
//        if (rootNode.LeftNode != null)
//        {
//            AddNode(rootNode.LeftNode, val);
//        }
//        else
//        {
//            rootNode.LeftNode = new Node(val);
//            return;
//        }

//    }
//    else
//    {
//        if (rootNode.RıghtNode != null)
//        {
//            AddNode(rootNode.RıghtNode, val);
//        }
//        else
//        {
//            rootNode.RıghtNode = new Node(val);
//            return;
//        }

//    }

//}

//void Traverse(Node rootNode)
//{
//    if (rootNode is null)
//    {
//        return;
//    }

//    Traverse(rootNode.LeftNode);
//    Console.WriteLine(rootNode.Val);
//    Traverse(rootNode.RıghtNode);

//}




//public class Node
//{
//    public Node(int val)
//    {
//        Val = val;
//    }
//    public int Val { get; set; }
//    public Node LeftNode { get; set; }
//    public Node RıghtNode { get; set; }
//}




