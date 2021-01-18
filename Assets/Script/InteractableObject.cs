using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public GameObject commandMenu;
    public ui_Manager ui_Manager;
    public Text dialogFenster;
    public string inspectText;
    public SpriteRenderer sr;
    public Image img;

    
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
}
