using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScenePicker : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        int progress = PlayerPrefs.GetInt("Progress", 1);
        Button[] buttons = new Button[transform.childCount];


        for(int i = 0; i < buttons.Length; i++)
        {
            buttons[i] = transform.GetChild(i).GetComponent<Button>();
            buttons[i].interactable = false;
        }

        for(int i = 0; i < progress; i++)
        {
            buttons[i].interactable = true;
        }
    }
}
