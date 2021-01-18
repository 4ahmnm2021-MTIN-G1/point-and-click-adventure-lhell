using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui_Manager : MonoBehaviour
{
    public InteractableObject activeIO;
    // public bool activeIO;
    public Text dialogFenster;

    public void DisplayText()
    {
        dialogFenster.text = activeIO.inspectText;
    }

    public void CollectItem()
    {
        Debug.Log("Collect Item Funktion ist aufgerufen");

        activeIO.img.sprite = activeIO.sr.sprite;

    }

    public void DontDisplayText()
    {
        dialogFenster.text = "";
    }
}
