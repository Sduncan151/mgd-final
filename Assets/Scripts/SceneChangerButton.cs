using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerButton : MonoBehaviour
{
    public int levelWithJump = 6;

    public void ChangeScene(int index)
    {
        // if we are in the main menu, reset all PlayerPrefs
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            PlayerPrefs.SetInt("Coin", 0);
            PlayerPrefs.SetInt("canJump", 0);
            // canDash
        }
        else if(SceneManager.GetActiveScene().buildIndex >= levelWithJump)
        {
            PlayerPrefs.SetInt("canJump", 1);
        }
        Time.timeScale = 1;


        UnityEngine.SceneManagement.SceneManager.LoadScene(index);
    }
}
