using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NaviTag : MonoBehaviour
{
    public string label;

    /// <summary>
    /// To be implemented.
    /// </summary>
    /// <returns></returns>
    abstract public int GetMaxIndex();

    /// <summary>
    /// Prints the labels of all the tags it holds references to.
    /// </summary>
    abstract public void PrintList();

    /// <summary>
    /// Prints the label of the tag held at a specific index.
    /// </summary>
    /// <param name="index"></param>
    abstract public void PrintLabel(int index);

    /// <summary>
    /// Activates the tag at the given index.
    /// </summary>
    /// <param name="index"></param>
    abstract public void Activate(int index, Navigator navigator);

    void Reset()
    {
        label = name;
    }

}
