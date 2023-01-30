using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Navigator : MonoBehaviour
{
    [SerializeField] UAP_AccessibilityManager accessibilityManager;

    int index = 0;
    [SerializeField] NaviTag target;
    [SerializeField] NaviTag defaultTarget;
    Stack<NaviTag> tagStack = new Stack<NaviTag>();
    Stack<int> indexStack = new Stack<int>();

    NaviTag[] hotkeys = new NaviTag[10];

    [SerializeField] bool rememberPosition;

    void Start()
    {
        defaultTarget = GetComponent<NaviTag>();
        SetTarget();
        accessibilityManager = FindObjectOfType<UAP_AccessibilityManager>();
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
            if (rememberPosition)
            {
                index = indexStack.Pop();
            }
            SetTarget(tagStack.Pop());
        }
    }

    public void ActivateTarget()
    {
        tagStack.Push(target);
        if (rememberPosition)
        {
            indexStack.Push(index);
        }
        target.Activate(index, this);
        index = 0;
    }

    public void ReturnToRoot()
    {
        SetTarget();
        tagStack.Clear();
        indexStack.Clear();
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

    public void HotKey(int index)
    {
        if(hotkeys[index] == null)
        {
            hotkeys[index] = target;
            Debug.Log("Hotkey " + target.label + " assigned to " + index.ToString());
        }
        else
        {
            tagStack.Push(target);
            indexStack.Push(index);
            SetTarget(hotkeys[index]);
        }
    }

    public void saySomething(string speech)
    {
        accessibilityManager.Saysomething(speech);
    }
    #endregion
}
