using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleControl : MonoBehaviour
{
    public GameObject obstacle;
    Queue<GameObject> ObjPool;

    float time;
    public float LimitTime;

    void Start()
    {
        time = 0;
        ObjPool = new Queue<GameObject>();

        for(int i=0;i<5;i++)
        {
            GameObject Obstacle = Instantiate(obstacle, gameObject.transform.position, Quaternion.identity);
            Obstacle.transform.parent = gameObject.transform;
            Obstacle.SetActive(false);
            ObjPool.Enqueue(Obstacle);
        }
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= LimitTime) 
        {
            time = 0;
            GameObject obj = Pop();
            obj.SetActive(true);
        }
    }

    public GameObject Pop()
    {
        return ObjPool.Dequeue();
    }

    public void Push(GameObject obj)
    {
        obj.SetActive(false);
        obj.transform.position = this.transform.position;
        ObjPool.Enqueue(obj); 
    }

   
}
