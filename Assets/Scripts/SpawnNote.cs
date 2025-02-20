using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour
{
    public GameObject note;

    //measures time
    public float t;
    //whether the timer is counting - just made it public for testing purposes
    public bool timerOn = false;

    //the prefab being spawned
    GameObject newNote;

    
    //this is used for making the prefabs last as long as the audio clip
    public AudioSource chirp;
    public float chirpLength;

    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //this variable is the length of the current audio clip
        chirpLength = chirp.clip.length;

        //if the timer is on, t counts upwards with delta time
        if (timerOn)
        {
            t += Time.deltaTime;
        }

        //if the timer has exceeded the length of the birdsong, it destroys itself, turns off the timer, and resets it to 0
        if (t > chirp.clip.length)
        {
            //then destroys it
            Destroy(newNote);
            timerOn = false;
            t = 0;
        }
    }

    
    public void Note()
    {
        //this takes the vector3 I made earlier and assigns it a random location local in screenspace to the bird
        pos.x = transform.localPosition.x + Random.Range(-2, 2);
        pos.y = transform.localPosition.y + Random.Range(-2, 2);
        pos.z = transform.localPosition.z + 0;

        

        //Then it instantiates a music note in that location
        newNote = Instantiate(note, pos, Quaternion.identity);

        //then it starts the destruction countdown
        timerOn = true;
      
        }
}


