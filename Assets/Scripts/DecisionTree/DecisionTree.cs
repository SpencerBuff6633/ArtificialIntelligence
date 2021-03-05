using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionTree : MonoBehaviour
{
    public DecisionNode root;
    public static int frame = 0;

    // Update is called once per frame
    void Update()
    {
        DecisionNode[] nodes = FindObjectsOfType<DecisionNode>();
        foreach (var node in nodes) node.State = DecisionNode.eState.Inactive;

        frame++;
        root.Execute();
    }
}
