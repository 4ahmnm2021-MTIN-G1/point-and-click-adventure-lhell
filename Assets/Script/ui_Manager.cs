using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ui_Manager : MonoBehaviour
{
    public InteractableObject activeIO;
    public Text dialogFenster;

    public void DisplayText()
    {
        activeIO.talk.Invoke();
    }

    public void CollectItem()
    {
        activeIO.Interact();
    }

    public void DontDisplayText()
    {
        dialogFenster.text = "";
    }
}
