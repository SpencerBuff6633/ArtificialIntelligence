using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static Vector3 Wrap(Vector3 v, Vector3 min, Vector3 max)
    {
        Vector3 result = v;

        // test result.x > max.x, if true result.x = min.x
        if (result.x > max.x)
        {
            result.x = min.x;
        }
        // test result.x < min.x, if true result.x = max.x
        if (result.x < min.x)
        {
            result.x = max.x;
        }
        // test result.y > max.y, if true result.y = min.y
        if (result.y > max.y)
        {
            result.y = min.y;
        }
        // test result.y < min.y, if true result.y = max.y
        if (result.y < min.y)
        {
            result.y = max.y;
        }
        // test result.z > max.z, if true result.z = min.z
        if (result.z > max.z)
        {
            result.z = min.z;
        }
        // test result.z < min.z, if true result.z = max.z
        if (result.z < min.z)
        {
            result.z = max.z;
        }
        return result;
    }

    public static float Dot(Vector3 v1, Vector3 v2)
    {
        return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
    }

}
