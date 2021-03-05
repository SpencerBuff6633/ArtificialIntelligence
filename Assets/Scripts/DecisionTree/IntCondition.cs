using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntCondition : Condition
{
    public enum eComparison
    {
        Equal,
        Greater,
        Less
    }

    public eComparison Comparison { get; set; } = eComparison.Equal;
    public int compareInt
    {
        set
        {
            Comparison = (eComparison)value;
        }
    }

    public int value { get; set; }
    public string valueString
    {
        set
        {
            int.TryParse(value, out int v);
            this.value = v;
        }
    }

    public float parameter { get; set; }

    public override bool IsTrue()
    {
        bool isTrue = false;

        switch (Comparison)
        {
            case eComparison.Equal:
                isTrue = ((int)parameter == value);
                break;
            case eComparison.Greater:
                isTrue = ((int)parameter > value);
                break;
            case eComparison.Less:
                isTrue = ((int)parameter < value);
                break;
            default:
                break;
        }

        return isTrue;
    }
}
