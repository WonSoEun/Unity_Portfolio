using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_Dial_Click : MonoBehaviour
{
    GameObject Step;
    AudioSource music;

    void Start()
    {     
        Step = GameObject.Find("Step");
        music = Step.GetComponent<AudioSource>();
    }

    public void Dial_Clik()
    {        
        if(Dial_S.open_Is)
        {
            music.Play();
            Invoke("Escape", 2f);           
        }
    }

    public void Escape()
    {
        SceneManager.LoadScene("escape");
    }
}
