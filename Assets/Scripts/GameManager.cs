using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private List<string> _names = new List<string> { "John", "Jane", "Doe" };

    void Start()
    {
        Debug.Log(_names.GetRandomItem());
    }

}
