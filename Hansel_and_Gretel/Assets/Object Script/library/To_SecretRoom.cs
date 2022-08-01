using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To_SecretRoom : MonoBehaviour
{
    public static bool start_SecretRoom = false;
    public static int count_S;

    public void Bookcase_Click()
    {
        if (Bookcase_IN.open_Is_bookcase)
        {
            SceneManager.LoadScene("Secret Room");
            if(count_S == 0) start_SecretRoom = true;
            count_S += 1;
        }
    }
}
