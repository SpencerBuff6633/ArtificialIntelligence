using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphNodeCreator : MonoBehaviour
{
    public GraphNode GraphNode;
    public LayerMask LayerMask;
    public float range = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo, 100, LayerMask))
            {
                GraphNode node = Instantiate(GraphNode, hitInfo.point, Quaternion.identity);
                GraphNode.UnlinkNodes();
                GraphNode.LinkNodes(range);
            }

        }
    }
    

}
