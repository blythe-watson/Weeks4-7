using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Volume : MonoBehaviour
{
    public AudioSource chirp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //this has space for a float, which will be a dynamic value that the slider can get a hold of
    public void changeVolume(float value)
    {

        chirp.volume = value;
    }

}
