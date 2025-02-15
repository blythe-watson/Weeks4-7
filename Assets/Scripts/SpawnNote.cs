using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour
{
    public GameObject note;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            pos.x = transform.localPosition.x + Random.Range(-2, 2);
            pos.y = transform.localPosition.y + Random.Range(-2, 2);
            pos.z = transform.localPosition.z + 0;
            GameObject newNote = Instantiate(note, pos, Quaternion.identity);
            
            Destroy(newNote, 3);
        }
    }
}
