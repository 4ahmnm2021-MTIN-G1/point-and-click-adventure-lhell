using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractableObject2 : MonoBehaviour
{
    public GameObject commandMenu;
    public ui_Manager ui_Manager2;
    public Text dialogFenster;
    
    public bool condition;
    public bool condition2;
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
    
       // ui_Manager2.activeIO = this;

    }

    public void Interact()
    {
        if (condition && condition2)
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
    public void SetCondition2(bool value)
        {
            condition2 = value;
        }
}
