using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform thisTransform;
    public Vector3 mousePos;
    public Vector3 worldPos;
    public Vector3 playerPos;
    public float speed = 0.1f;
    public GameObject player;
    public Camera MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = thisTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
      MainCamera.transform.position = new Vector3(thisTransform.position.x, thisTransform.position.y, -10);
      thisTransform.position = Vector3.MoveTowards(thisTransform.position, playerPos, speed);
    }

    public void SetNewDesination()
    {
            mousePos = Input.mousePosition; 
            worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            playerPos = new Vector3(worldPos.x, worldPos.y, thisTransform.position.z); 
    }


}
