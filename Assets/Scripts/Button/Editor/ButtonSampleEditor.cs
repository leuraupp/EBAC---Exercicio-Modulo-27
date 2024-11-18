using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ButtonSample))]
public class ButtonSampleEditor : Editor
{
    public override void OnInspectorGUI() {
        //base.OnInspectorGUI();

        ButtonSample buttonSample = (ButtonSample)target;
        buttonSample.obj = (GameObject)EditorGUILayout.ObjectField("Game Object", buttonSample.obj, typeof(GameObject), true);

        if (GUILayout.Button("Show random name")) {
            buttonSample.ShowRandomName();
        }

        if (GUILayout.Button("Show game object")) {
            buttonSample.ShowGameObject();
        }
    }
}
