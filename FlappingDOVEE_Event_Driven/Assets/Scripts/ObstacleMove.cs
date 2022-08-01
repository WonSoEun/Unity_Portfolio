using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float obstacleSpeed;

    void Start()
    {
        
    }

    private void OnEnable()
    {
        transform.position = new Vector3(4.5f, Random.Range(-3f, 3f), 0);
    }

    void Update()
    {
        transform.Translate(Vector3.left * obstacleSpeed * Time.deltaTime);
        if(transform.position.x<-4.5f || !(GameManager.gm.state==GameState.GamePlay))
        {
            this.transform.parent.GetComponent<ObstacleControl>().Push(gameObject);
        }
    }
}
