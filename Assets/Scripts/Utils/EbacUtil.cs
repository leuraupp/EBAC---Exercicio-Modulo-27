using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EbacUtil
{
    public static T GetRandomItem<T>(this List<T> list) {
        return list[Random.Range(0, list.Count)];
    }

    [UnityEditor.MenuItem("EBAC/Instantiate Object")]
    public static void InstantiateObject() {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}
