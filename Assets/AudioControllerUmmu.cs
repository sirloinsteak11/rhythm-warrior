using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllerUmmu : MonoBehaviour
{

    public AudioSource ummu;
    public KeyCode playKey = KeyCode.None;
    public KeyCode pauseKey = KeyCode.None;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(playKey))
        {
            ummu.Play(0);
        }

        if(Input.GetKeyDown(pauseKey))
        {
            ummu.Pause();
        }
    }
}
