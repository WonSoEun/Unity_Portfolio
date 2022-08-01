using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class PlayerControl : MonoBehaviour
{
    public float jumpPower;
    Rigidbody rb;

    public UnityEvent PlayerDead;

    Animator ani;
    AudioSource audio;
    public AudioClip jumpSound;
    public AudioClip deadSound;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }
    void Start()
    {
        transform.position = new Vector3(-1.8f, 0, -2);
    }

    void Update()
    {
        BirdMove();
    }
    
    public void BirdMove()
    {
        rb.isKinematic = false;
        rb.useGravity = true;
        if (Input.GetMouseButtonDown(0) && GameManager.gm.state==GameState.GamePlay)
        {
            
            audio.clip = jumpSound;
            audio.Play();
            rb.velocity = new Vector3(0, 0, 0);
            rb.AddForce(0, jumpPower, 0, ForceMode.VelocityChange);
        }
    }

    public void Player_Reset()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
        gameObject.SetActive(false); 
        ani.SetTrigger("ReStart");
        transform.position = new Vector3(-1.8f, 0, -2);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Obstacle") && GameManager.gm.state == GameState.GamePlay)
        {
            audio.clip = deadSound;
            audio.Play();
            ani.SetTrigger("Dead");
            PlayerDead.Invoke(); //gm의 changeState불러야함. - st=2;
        }
        else if(other.CompareTag("Goal") && GameManager.gm.state != GameState.GameOver)
        {
            GameManager.gm.GetScore();
        }
    }



}
