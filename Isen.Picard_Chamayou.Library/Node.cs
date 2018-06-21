using System;
using System.Collections.Generic;

namespace Isen.Picard_Chamayou.Library
{
    public class Node : INode, IEquatable<Node>
    {
        //value = string + getter + setter
        public string value { get; set; }

        //id = autogenere + getter
        public Guid id { get; }
        //parent = Node + getter + setter
        public Node parent { get; set; }

        //children = list<Node> + getter + setter
        public List<Node> children { get; set; }
        //depth = int + getter
        public int depth { get; }

        public bool Equals(Node other)
        {
            //si other reference un objet null
            if(other == null){
                return false;
            }
            //si other ne reference pas un objet de type Node
            if(!(other is Node)){
                return false;
            }
            //si les id et les values sont egaux
            if(id.Equals(other.id) && string.Equals(value, other.value)){
                return true;
            }
            else return false;
        }
    }
}