using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Navigator : MonoBehaviour
{
    int index = 0;
    [SerializeField] NaviTag target;
    [SerializeField] NaviTag defaultTarget;
    Stack<NaviTag> tagStack = new Stack<NaviTag>();

    //List<NaviTag> hotkeys = new List<NaviTag>();


    void Start()
    {
        defaultTarget = GetComponent<NaviTag>();
        SetTarget();
    }

    #region Actions
    public void NextItem()
    {
        if (index < target.GetMaxIndex())
        {
            index++;
            target.PrintLabel(index);
        }
        else
        {
            Debug.Log("Already at end of list");
        }
    }

    public void PreviousItem()
    {
        if (index > 0)
        {
            index--;
            target.PrintLabel(index);
        }
        else
        {
            Debug.Log("Already at start of list");
        }
    }

    public void ExitLevel()
    {
        if (tagStack.Count > 0)
        {
            index = 0;
            SetTarget(tagStack.Pop());
        }
    }

    public void ActivateTarget()
    {
        tagStack.Push(target);
        target.Activate(index, this);
        index = 0;
    }

    public void ReturnToRoot()
    {
        SetTarget();
        tagStack.Clear();
        index = 0;
    }

    #endregion

    #region Public Methods
    public void SetTarget(NaviTag newTarget = null)
    {
        if (target != null)
        {
            target = newTarget;
        }
        else
        {
            target = defaultTarget;
        }
        if(target == null)
        {
            target = defaultTarget;
        }
        target.PrintList();
    }
    #endregion
}
