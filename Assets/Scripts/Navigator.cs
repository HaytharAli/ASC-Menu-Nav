using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigator : MonoBehaviour
{
    [SerializeField] NaviTag target;
    Stack<NaviTag> tagStack = new Stack<NaviTag>();
    [SerializeField] int index = 0;

    void Start()
    {
        target = GetComponent<NaviTag>();
        tagStack.Push(target);
    }

    public void NextItem()
    {
        if (index < target.getMaxIndex())
        {
            index++;
        }
    }

    public void PreviousItem()
    {
        if (index > 0)
        {
            index--;
        }
    }

    public void EnterLevel()
    {
        NaviTag newTarget;
        newTarget = target.getTag(index);
        if (newTarget != null)
        {
            target = newTarget;
            index = 0;
        }
        else
        {
            Debug.LogError("No tag existed at given index.");
        }
    }

    public void ExitLevel()
    {
        index = 0;
        target = tagStack.Pop();
    }

    public void ReturnToRoot()
    {
        index = 0;
        target = GetComponent<NaviTag>();
    }

    List<NaviTag> hotkeys = new List<NaviTag>();



}
