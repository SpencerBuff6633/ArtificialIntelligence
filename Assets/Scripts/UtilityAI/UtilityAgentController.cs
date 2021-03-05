using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityAgentController : MonoBehaviour
{
    public UtilityAgent agent;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit raycastHit))
            {
                agent.Movement.MoveTowards(raycastHit.point);
            }

        }

    }
}
