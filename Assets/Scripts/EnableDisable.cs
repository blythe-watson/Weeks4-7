using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject thing;
    public SpriteRenderer sr;
    public EnableDisable script;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            sr.enabled = false;
            //script.enabled = false;
            thing.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.enabled = true;
            //script.enabled = true;
            thing.SetActive(false);
        }
    }
}
