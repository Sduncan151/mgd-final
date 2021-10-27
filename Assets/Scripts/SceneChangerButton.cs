using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangerButton : MonoBehaviour
{
    public void ChangeScene(int index)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(index);
    }
}
