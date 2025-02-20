using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour
{
    public GameObject note;
    //gonna be honest I thought that the destroy counter counted as a timer :(
    public float duration = 5;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void Size()
    {

    }
    
    public void Note()
    {
        //this takes the vector3 I made earlier and assigns it a random location local in screenspace to the bird
        pos.x = transform.localPosition.x + Random.Range(-2, 2);
        pos.y = transform.localPosition.y + Random.Range(-2, 2);
        pos.z = transform.localPosition.z + 0;

        //Then it instantiates a music note in that location
        GameObject newNote = Instantiate(note, pos, Quaternion.identity);
        //then destroys it
        Destroy(newNote, duration);
    }
}


