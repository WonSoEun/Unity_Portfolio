using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private static DontDestroy instance = null;

    void Awake()
    {
        if(instance)
        {
            DestroyImmediate(this.gameObject);
            return;
        }


        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
