using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BirdManager : MonoBehaviour
{
    //setting up all the sprites - these are public so I can drop things into them in the inspector
    public Sprite bluejay;
    public Sprite cardinal;
    public Sprite dove;
    public Sprite chickadee;
    public SpriteRenderer r;

    //same logic as the sprites above
    public AudioClip bluejayCall;
    public AudioClip cardinalCall;
    public AudioClip doveCall;
    public AudioClip chickadeeCall;
    public AudioSource a;
    
    public TextMeshProUGUI species;

    //public Slider slider;

    float volume;

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
        a.volume = volume;

        //this changes the display text to tell us what bird we're looking at, and changes the text colour
        species.text = "Bluejay";
        species.faceColor = Color.blue;
    }

    //exact same logic as the bluejay
    public void CardinalSprite()
    {
        SpriteRenderer r = GetComponent<SpriteRenderer>();
        r.sprite = cardinal;

        AudioSource a = GetComponent<AudioSource>();
        a.clip = cardinalCall;
        a.volume = volume;

        species.text = "Cardinal";
        species.faceColor = Color.red;
    }

    public void DoveSprite()
    {
        SpriteRenderer r = GetComponent<SpriteRenderer>();
        r.sprite = dove;

        AudioSource a = GetComponent<AudioSource>();
        a.clip = doveCall;
        a.volume = volume;

        species.text = "Mourning dove";
        species.faceColor = Color.green;
    }

    public void ChickadeeSprite()
    {
        SpriteRenderer r = GetComponent<SpriteRenderer>();
        r.sprite = chickadee;

        AudioSource a = GetComponent<AudioSource>();
        a.clip = chickadeeCall;
        a.volume = volume;

        species.text = "Chickadee";
        species.faceColor = Color.black;
    }


}
