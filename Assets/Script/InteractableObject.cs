﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public GameObject commandMenu;
    public Transform reposition;
    public UI_Manager UI_Manager;
    public Text dialogFenster;
    public string inspectText;
    
    //Erster Frame des Objektes in der Szene
    public void start()
    {
        commandMenu.active = false;
    }
    
    //Diese Funktion wird jeden Frame aufgerufen
    public void update()
    {
    
    }
    
    public void OnMouseDown()
    {
        command.Menu.active = true;
        commandMenu.transform.position = transform.position;

        dialogFenster.text = inspectText;
    
        UI_Manager.activeIO = this;
    }
}
