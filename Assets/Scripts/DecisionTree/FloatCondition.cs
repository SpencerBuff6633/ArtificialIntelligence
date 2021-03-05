using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatCondition : Condition
{
    public enum eComparison
    {
        Equal,
        Greater,
        Less
    }

    public eComparison Comparison { get; set; } = eComparison.Equal;
    public int compareFloat
    {
        set
        {
            Comparison = (eComparison)value;
        }
    }

    public float value { get; set; }
    public string valueString
    {
        set
        {
            float.TryParse(value, out float v);
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
                isTrue = (parameter == value);
                break;
            case eComparison.Greater:
                isTrue = (parameter > value);
                break;
            case eComparison.Less:
                isTrue = (parameter < value);
                break;
            default:
                break;
        }

        return isTrue;
    }
}
