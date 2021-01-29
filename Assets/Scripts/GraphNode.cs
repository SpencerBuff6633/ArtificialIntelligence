using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphNode : SearchNode
{
    public enum eType
    {
        Default,
        Source,
        Destination,
        Path, 
        Visited
    }

    Color[] colors =
    {
        Color.white,
        Color.green,
        Color.red,
        Color.yellow,
        Color.blue
    };

    public struct Edge
    {
        public GraphNode nodeA;
        public GraphNode nodeB;
    }

    public List<Edge> Edges { get; set; } = new List<Edge>();
    public eType Type { get; set; } = eType.Default;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.color = colors[(int)Type];
    }

    public static GraphNode[] GetGraphNodes()
    {
        return GameObject.FindObjectsOfType<GraphNode>();
    }

    public static GraphNode GetGraphNode(eType type)
    {
        GraphNode graphNode = null;

        GraphNode[] graphNodes = GetGraphNodes();
        foreach(GraphNode node in graphNodes)
        {
            if(node.Type == type)
            {
                return graphNode;
            }
        }
        return null;
    }

    public static void UnlinkNodes()
    {
        GraphNode[] graphNodes = GetGraphNodes();
        foreach (GraphNode graphNode in graphNodes)
        {
            graphNode.Edges.Clear();
        }
    }

    public static void LinkNodes(float range)
    {
        GraphNode[] graphNodes = GetGraphNodes();
        foreach (GraphNode graphNode in graphNodes)
        {
            //LinkNodes()
        }
    }
}
