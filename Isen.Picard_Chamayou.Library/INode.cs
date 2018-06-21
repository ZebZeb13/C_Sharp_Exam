using System;
using System.Collections.Generic;

namespace Isen.Picard_Chamayou.Library
{
    public interface INode
    {
        string value { get; set; }
        Guid id { get; }
        Node parent { get; set; }
        List<Node> children { get; set; }
        int depth { get; }

    }
}