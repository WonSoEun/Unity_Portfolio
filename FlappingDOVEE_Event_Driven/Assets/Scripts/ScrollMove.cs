using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollMove : MonoBehaviour
{
    float targetOffset;
    Renderer rd;
    float speed = 0;
    float acceleration = 0.5f; //가속도

    private void Awake()
    {
        rd = GetComponent<Renderer>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void scrollBG_Start(float maxSpeed) //float maxSpeed 만큼 스크롤 되게함(이벤트에서 maxSpeed 조정가능)
    {
        if (speed > maxSpeed) // 가속
        {
            speed -= acceleration * Time.deltaTime;
        }
        targetOffset += Time.deltaTime * speed;
        rd.material.mainTextureOffset = new Vector2(targetOffset, 0);
    }

    public void scrollBG_End(float maxSpeed)  //감속
    {
        speed += acceleration * Time.deltaTime;
        if (speed >= 0f) speed = 0;
        
        targetOffset += Time.deltaTime * speed;
        rd.material.mainTextureOffset = new Vector2(targetOffset, 0);
    }

        
        
    
}
