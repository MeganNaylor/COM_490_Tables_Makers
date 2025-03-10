// This can be used to call functions in a little pause menu attached to the hand
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //TEMPORARY SCENE RESET with R
        if (Input.GetKeyDown(KeyCode.R))
        {
            //Load Cunstruction Scene
            SceneManager.LoadScene("ConstructionScene");
        }
    }
}