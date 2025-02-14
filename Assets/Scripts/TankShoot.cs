using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{

    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouse = (Camera.main.ScreenToWorldPoint(Input.mousePosition));
        //transform.position = mouse;



        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bullet);
            //newBullet
            Destroy(newBullet, 5);
        }
    }
}
