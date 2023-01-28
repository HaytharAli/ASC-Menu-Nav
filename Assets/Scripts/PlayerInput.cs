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
    }
}
