using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Synop_Fire : MonoBehaviour
{
    public GameObject Fire; // ����

    void Start()
    {
        StartCoroutine(Boom());
    }

    void Update()
    {
        
            
    }

    IEnumerator Boom()
    {
        Instantiate(Fire, new Vector3(-1.5f, 3, -1), transform.rotation); //������ ��ġ���� ��Ÿ��.
        yield return new WaitForSeconds(1f);
        Instantiate(Fire, new Vector3(1.5f, 3, -1), transform.rotation);
        yield return new WaitForSeconds(1.5f);

        Instantiate(Fire, new Vector3(-1.5f, 3, -1), transform.rotation);
        yield return new WaitForSeconds(1.5f);
        Instantiate(Fire, new Vector3(1.5f, 3, -1), transform.rotation);
    }    
}
