using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Synop_Fire : MonoBehaviour
{
    public GameObject Fire; // 폭죽

    void Start()
    {
        StartCoroutine(Boom());
    }

    void Update()
    {
        
            
    }

    IEnumerator Boom()
    {
        Instantiate(Fire, new Vector3(-1.5f, 3, -1), transform.rotation); //정해진 위치에서 나타남.
        yield return new WaitForSeconds(1f);
        Instantiate(Fire, new Vector3(1.5f, 3, -1), transform.rotation);
        yield return new WaitForSeconds(1.5f);

        Instantiate(Fire, new Vector3(-1.5f, 3, -1), transform.rotation);
        yield return new WaitForSeconds(1.5f);
        Instantiate(Fire, new Vector3(1.5f, 3, -1), transform.rotation);
    }    
}
