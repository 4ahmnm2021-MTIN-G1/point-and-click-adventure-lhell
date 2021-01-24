﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    public GameObject commandMenu;
    public ui_Manager ui_Manager;
    public Text dialogFenster;
    
    public bool condition;
    public UnityEvent conditionMet;
    public UnityEvent conditionNotMet;

    public UnityEvent talk;
    
    //Erster Frame des Objektes in der Szene
    public void Start()
    {
        commandMenu.active = false;
    }
    
    //Diese Funktion wird jeden Frame aufgerufen
    public void Update()
    {
    
    }
    
    public void OnMouseDown()
    {
        commandMenu.active = true;
        commandMenu.transform.position = transform.position;

        //dialogFenster.text = inspectText;
    
        ui_Manager.activeIO = this;

    }

    public void Interact()
    {
        if (condition)
        {
            conditionMet.Invoke();
        }
        else 
        {
            conditionNotMet.Invoke();
        }
    }

     public void SetCondition(bool value)
        {
            condition = value;
        }
}
