using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B_Dial_Clik : MonoBehaviour
{
    public static bool start_corrider = false;
    public static int count_C;
    
    public void Dial_Clik()
    {
        if (B_Dial.open_Is == false)
        {
            SceneManager.LoadScene("BedRoom_Dial");
        }
        else
        {
            SceneManager.LoadScene("Corrider");
            if(count_C == 0 ) start_corrider = true;
            count_C += 1;            
        }
    }
}
