using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerButton : MonoBehaviour
{
    public void ChangeScene(int index)
    {
        // if we are in the main menu, reset all PlayerPrefs
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            PlayerPrefs.SetInt("Coin", 0);
            PlayerPrefs.SetInt("canJump", 0);
            // canDash
        }


        UnityEngine.SceneManagement.SceneManager.LoadScene(index);
    }
}
