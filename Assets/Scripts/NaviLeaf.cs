using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class NaviLeaf : NaviTag
{
    List<string> actions = new List<string>();

    public override void Activate(int index, Navigator navigator)
    {
        switch (index)
        {
            case 0:
                navigator.transform.position = transform.position;
                break;
            case 1:
                navigator.transform.LookAt(transform.position);
                break;
            case 2:
                Debug.LogWarning("This feature is not yet implemented");
                break;
            case 3:
                Debug.LogWarning("This feature is not yet implemented");
                break;
        }

        navigator.ReturnToRoot();
    }

    public override void PrintLabel(int index)
    {
        Debug.Log(actions[index]);
        _accessibilityManager.Saysomething(actions[index]);
    }

    public override void PrintList()
    {
        string output = "";
        foreach (string action in actions)
        {
            output += action + ", ";
        }
        Debug.Log(output);
        _accessibilityManager.Saysomething(output);
    }

    public override int GetMaxIndex()
    {
        return actions.Count - 1;
    }

    void OnValidate()
    {
        actions.Add("Go to " + label);
        actions.Add("Point to " + label);
        actions.Add("Place Audio Beacon at " + label);
        actions.Add("Save " + label + " as Hotkey");
    }
}
