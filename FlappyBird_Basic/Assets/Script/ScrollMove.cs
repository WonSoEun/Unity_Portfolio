using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollMove : MonoBehaviour
{
    public float scrollSpeed;
    float targetOffset;
    Renderer rd;

    void Start()
    {
        rd = GetComponent<Renderer>();    
    }

    void Update()
    {
        targetOffset += Time.deltaTime * scrollSpeed;
        rd.material.mainTextureOffset = new Vector2(targetOffset, 0);
    }
}
