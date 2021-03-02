using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move up at 10 speed
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (transform.position.y >= 6)
        {
            Destroy(this.gameObject);
        }
    }
}
