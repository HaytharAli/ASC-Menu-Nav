using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaviTag : MonoBehaviour
{
    [SerializeField] List<NaviTag> subTags = new List<NaviTag>();

    public NaviTag getTag(int index)
    {
        if (subTags.Count > index)
        {
            return subTags[index];
        }
        else
        {
            return null;
        }
    }

    public int getMaxIndex()
    {
        return subTags.Count - 1;
    }
}
