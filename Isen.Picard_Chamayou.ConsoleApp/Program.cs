using System;
using Isen.Picard_Chamayou.Library;


namespace Isen.Picard_Chamayou.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node i1 = new Node("Item1");
            Node i11 = new Node("Item11");
            Node i12= new Node("Item12");
            Node i13 = new Node("Item13");
            Node i111 = new Node("Item111");
            Node i112 = new Node("Item112");
            Node i113 = new Node("Item112");
            Node i1111 = new Node("Item1111");
            Node i1121 = new Node("Item1121");
            Node i1122 = new Node("Item1122");

            i1.AddChildNode(i11);
            i11.AddChildNode(i111);
            i111.AddChildNode(i1111);
            i11.AddChildNode(i112);
            i112.AddChildNode(i1121);
            i112.AddChildNode(i1122);
            i11.AddChildNode(i113);
            i1.AddChildNode(i12);
            i1.AddChildNode(i13);

            Console.WriteLine(i1.ToString());
        }
    }
}
