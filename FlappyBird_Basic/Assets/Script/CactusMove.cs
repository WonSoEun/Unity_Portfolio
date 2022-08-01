using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusMove : MonoBehaviour
{
    public float cactusSpeed;


    void Start()
    {
            
    }

    void Update()
    {
        transform.Translate(Vector3.left * cactusSpeed * Time.deltaTime);
        if (transform.position.x < -6f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnEnable() //Start함수보다 빨리 실행, Awake함수보다는 느리게 실행.
    {
        transform.position = new Vector3(6f, Random.Range(-1, 1.5f), 0);
    }
}
