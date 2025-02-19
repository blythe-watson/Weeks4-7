using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : MonoBehaviour
{
    //setting up all the sprites - these are public so I can drop things into them in the inspector
    public Sprite bluejay;
    public Sprite cardinal;
    public SpriteRenderer r;

    //same logic as the sprites above
    public AudioClip bluejayCall;
    public AudioClip cardinalCall;
    public AudioSource a;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When this function is called, it reaches into the spriterenderer and gives it the bluejay sprite that I dropped in the inspector
    //it also reaches into the audiosource and gives it the bluejay call
    public void BlueJaySprite()
    {
        SpriteRenderer r = GetComponent<SpriteRenderer>();
        r.sprite = bluejay;
        AudioSource a = GetComponent<AudioSource>();
        a.clip = bluejayCall;
    }


    //same logic as the bluejay
    public void CardinalSprite()
    {
        SpriteRenderer r = GetComponent<SpriteRenderer>();
        r.sprite = cardinal;
        AudioSource a = GetComponent<AudioSource>();
        a.clip = cardinalCall;
    }

}
