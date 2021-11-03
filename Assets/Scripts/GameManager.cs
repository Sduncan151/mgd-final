using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform startPosition;

    // create the player before any other Start() functions happen.
    void Awake()
    {
        if(startPosition == null)
        {
            Debug.LogError("<color=red>You have not selected a start position.</color>");
        }
        Instantiate(playerPrefab, startPosition.position, startPosition.rotation);
    }
}
