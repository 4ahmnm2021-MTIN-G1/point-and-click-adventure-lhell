using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArea : MonoBehaviour
{
    public PlayerMovement pm;
    public int orderLayer;
    public SpriteRenderer sr;

    public void OnMouseDown() 
    {
        pm.SetNewDesination();
        Debug.Log("Click erkannt");
        sr.sortingOrder = orderLayer;
    }
}
