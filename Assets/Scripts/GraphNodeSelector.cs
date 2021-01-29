using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphNodeSelector : MonoBehaviour
{
    public LayerMask layerMask;
    public GameObject selection;

    public bool IsActive { get { return selection.activeSelf; } }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 100, layerMask))
        {
            GraphNode graphNode = hitInfo.collider.GetComponent<GraphNode>();

            selection.SetActive(true);
            selection.transform.position = hitInfo.collider.transform.position;

            if (Input.GetMouseButtonDown(1))
            {
                if(Input.GetKey(KeyCode.S))
                {
                    graphNode.Type = GraphNode.eType.Source;

                }
                else if (Input.GetKey(KeyCode.D))
                {
                    graphNode.Type = GraphNode.eType.Destination;
                }
            }
        }
        else
        {
            selection.SetActive(false);
        }
    }
}
