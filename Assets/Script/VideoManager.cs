using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour
{
    public VideoClip clip;
    public double length;
    public RawImage image;

    private void  Start ()
    {
        length = clip.length;
    }
    
    public void DelayedFunction()
    {
        Invoke("TurnOffImage", (float)length);
    }

    public void TurnOffImage()
    {
        image.enabled = false;
    }
}
