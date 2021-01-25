using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractableObject2 : MonoBehaviour
{
    public GameObject commandMenu;
    public ui_Manager ui_Manager;
    public Text dialogFenster;
    
    public bool condition;
    public bool condition2;
    public UnityEvent conditionMet;
    public UnityEvent conditionNotMet;

    public UnityEvent talk;
    
    
    public void OnMouseDown2()
    {
        commandMenu.active = true;
        commandMenu.transform.position = transform.position;

        //dialogFenster.text = inspectText;
    
        //ui_Manager.activeIO = this;

    }

    public void Interact2()
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
