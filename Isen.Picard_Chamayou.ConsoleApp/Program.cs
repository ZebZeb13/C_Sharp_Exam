using System;
using Isen.Picard_Chamayou.Library;


namespace Isen.Picard_Chamayou.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example ...");
            var i1 = new Node<string>("Item1");

            var i11 = new Node<string>("Item11");
            var i12= new Node<string>("Item12");
            var i13 = new Node<string>("Item13");
        
            var i111 = new Node<string>("Item111");
            var i112 = new Node<string>("Item112");
            var i113 = new Node<string>("Item112");
            
            var i1111 = new Node<string>("Item1111");
            var i1121 = new Node<string>("Item1121");
            var i1122 = new Node<string>("Item1122");

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
