using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    float shakes = 0f;
    float shakeAmount = 0.7f;
    float decreaseFactor = 1.0f;
    Vector3 originalPos;
    bool CameraShaking;

    void Start()
    {
        originalPos = gameObject.transform.position;
        CameraShaking = false;
    }

    void Update()
    {
        
    }

    public void ShakeCamera(float shaking)
    {
        shakes = shaking;
        originalPos = gameObject.transform.position;
        CameraShaking = true;
    }
    private void FixedUpdate()
    {
        if(CameraShaking)
        {
            if(shakes>0)
            {
                gameObject.transform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
                gameObject.transform.position += new Vector3(0f, 0f, -50f);
                shakes -= Time.deltaTime * decreaseFactor;
            }
            else
            {
                shakes = 0f;
                gameObject.transform.localPosition = originalPos;
                CameraShaking = false;
            }
        }
    }

}
