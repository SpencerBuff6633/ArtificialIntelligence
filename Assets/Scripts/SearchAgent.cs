using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchAgent : MonoBehaviour
{
    public WaypointNode Waypoint;
    // Update is called once per frame
    void Update()
    {
        if (Waypoint != null)
        {
            Vector3 direction = Waypoint.transform.position - transform.position;
            transform.position += direction.normalized * 2 * Time.deltaTime;
        }
    }
}
