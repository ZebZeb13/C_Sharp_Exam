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

        public void AddChildNode(Node node)
        {
            node.parent = this;
            this.children.Add(node);
        }

        public void AddNodes(IEnumerable<Node> nodeList)
        {
           foreach (var node in nodeList)
            {
                AddChildNode(node);
            }
        }

       
        public void RemoveChildNotde(Guid id)
        {
            foreach (var node in children)
            {
                if (id == node.id){
                    this.children.Remove(node);
                }
            }
        }

         public void RemoveChildNode(Node node)
        {
           foreach (var nod in children)
            {
                if (node.Equals(nod)){
                    this.children.Remove(nod);
                }
            }
        }

    public Node FindTraversing(Guid id)
        {
            if (children == null){
                return null;
            }
            foreach (var nod in children)
            {
                if (nod.id == id){
                    return  nod;
                }
                var ret = nod.FindTraversing(id);
                if (ret != null){
                    return ret;
                }
            }
            return null;
        }

        public Node FindTraversing(Node node)
        {
            if (children == null){
                return null;
            }
            foreach (var nod in children)
            {
                if (nod.Equals(node)){
                    return  nod;
                }
                var ret = nod.FindTraversing(node);
                if (ret != null){
                    return ret;
                }
            }
            return null;
        }
        
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
            if(this.id.Equals(other.id) && string.Equals(this.value, other.value)){
                return true;
            }
            else return false;
        }

    
    }
       
}