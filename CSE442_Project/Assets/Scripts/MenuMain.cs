﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMain : MonoBehaviour {
    
    public bool isNew;
    public bool isQuit;
    public bool isStart;

    void OnMouseUp()
    {
        if (isNew){
            //MeshRenderer render = gameObject.GetComponentInChildren<MeshRenderer>();
            //render.enabled = false;

            SceneManager.LoadScene("MENU-Instructions");
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (isQuit){
            Application.Quit();
        }
        if (isStart)
        {
            //MeshRenderer render = gameObject.GetComponentInChildren<MeshRenderer>();
            //render.enabled = false;

            SceneManager.LoadScene("MAP-Level1");
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
