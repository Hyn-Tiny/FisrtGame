using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameObjectByNameHide
{
    //ham tim cac gameobject bang ten o hierachy bi an di
    public static GameObject FindGameObjectByName(string name)
    {
        Transform[] transforms = Resources.FindObjectsOfTypeAll<Transform>();
        foreach (Transform t in transforms)
        {
            if (t.hideFlags == HideFlags.None && t.name == name)
            {
                return t.gameObject;
            }
        }
        return null;
    }
}
