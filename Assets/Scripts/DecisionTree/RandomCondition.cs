using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCondition : Condition
{
	public bool value { get; set; }

	public override bool IsTrue()
	{
		if ((prevFrame + 1) != DecisionTree.frame)
		{
			if (Random.Range(0, 5) > 2.5)
            {
				value = true;   
            }
            else
            {
				value = false;
            }
		}

		prevFrame = DecisionTree.frame;

		return value;
	}

}
