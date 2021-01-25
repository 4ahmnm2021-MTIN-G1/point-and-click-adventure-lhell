using System.Collections;
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
    public bool condition2;
    public bool condition3;
    
    public UnityEvent conditionMet;
    public UnityEvent conditionNotMet;
    public UnityEvent bothConditionsMet;
    public UnityEvent allThreeConditionsMet;

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

        if(condition2 && condition)
        {
            bothConditionsMet.Invoke();
        }

        if(condition2 && condition && condition3)
        {
            allThreeConditionsMet.Invoke();
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
    public void SetCondition3(bool value)
        {
            condition3 = value;
        }
}
