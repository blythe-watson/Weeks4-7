using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboardcontrol : MonoBehaviour
{
    public float speed = 5;
    public Vector2 SqPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);

        SqPos = transform.position;
    }
}
