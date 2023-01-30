using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaviBranch : NaviTag
{
    [SerializeField] List<NaviTag> items = new List<NaviTag>();

    public override void Activate(int index, Navigator navigator)
    {
        navigator.SetTarget(items[index]);
    }

    public override void PrintLabel(int index)
    {
        Debug.Log(items[index].label);
        _accessibilityManager.Saysomething(items[index].label);
    }

    public override void PrintList()
    {
        string output = "";
        foreach(NaviTag tag in items)
        {
            output += tag.label + ", ";
        }
        Debug.Log(output);
        _accessibilityManager.Saysomething(output);
    }

    public override int GetMaxIndex()
    {
        return items.Count - 1;
    }
}
