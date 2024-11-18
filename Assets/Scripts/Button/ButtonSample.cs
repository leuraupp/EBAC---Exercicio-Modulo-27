using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSample : MonoBehaviour
{
    public List<string> names = new List<string> { "John", "Jane", "Doe" };
    public GameObject obj;

    public void ShowRandomName() {
        Debug.Log(names.GetRandomItem());
    }

    public void ShowGameObject() {
        Instantiate(obj);
    }
}
