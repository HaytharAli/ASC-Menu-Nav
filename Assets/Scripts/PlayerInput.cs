using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    Navigator navigator;

    void Start()
    {
        navigator = GetComponent<Navigator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            navigator.NextItem();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            navigator.PreviousItem();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            navigator.ActivateTarget();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            navigator.ExitLevel();
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            navigator.ReturnToRoot();
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            navigator.HotKey(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            navigator.HotKey(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            navigator.HotKey(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            navigator.HotKey(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            navigator.HotKey(4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            navigator.HotKey(5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            navigator.HotKey(6);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            navigator.HotKey(7);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            navigator.HotKey(8);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            navigator.HotKey(9);
        }
    }
}
