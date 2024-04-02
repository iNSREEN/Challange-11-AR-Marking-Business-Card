using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video; // Import the Video namespace

public class Traked : MonoBehaviour
{
    public VideoPlayer video; // Reference to the VideoPlayer component directly

    public void PlayVido()
    {

            video.Play(); // Start playing the video
      
    }

    public void StopVido()
    {

            video.Stop(); // Stop playing the video
        
    }
}
