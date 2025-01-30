using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePiece : MonoBehaviour
{

    public float speed = 1;

    public AudioSource audio;
    public AudioClip clip;

    public float hour;
    public float oClock;

    public float angle;

    public bool chimer;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //make a vector to copy the current angle of the axis
        Vector3 rot = transform.eulerAngles;

        //subtract one from the angle every frame, slowed by deltaTime
        rot.z -= speed * Time.deltaTime;

        //this increases at the same rate as the angle but resets when it reaches 30
        hour += speed * Time.deltaTime;

        //then update the angle
        transform.eulerAngles = rot;

        //if the time is 13, it's actually 1. get that 24 hour clock outta here
        if (oClock == 13)
        {
            oClock = 0;
        }


        //if the counter we set up gets over 30, it resets to 0 and adds 1 to the time (1 o'Clock, 2 o'Clock, etc)
        if (hour >= 30)
        {
            hour = 0;
            
            oClock += 1;
            chimer = true;

            
            
        }

        if (chimer)
        {
            timer += 1;

            
         //this is meant to play th audio multiple times relative to the current time
           for (int i = 0; i < oClock; i++)
           {
                if (timer >= timer * 2 * oClock)
                {
                    audio.PlayOneShot(clip);
                }
            }
        }


        //for display purposes in the inspector
        angle = rot.z;

    }
}
