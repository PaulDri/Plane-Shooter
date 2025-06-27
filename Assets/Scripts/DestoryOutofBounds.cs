using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutofBounds : MonoBehaviour
{
    private float leftBound = -11f;
    private float rightBound = 18f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftBound) 
        {
            Destroy(gameObject);
        }

        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }
}
