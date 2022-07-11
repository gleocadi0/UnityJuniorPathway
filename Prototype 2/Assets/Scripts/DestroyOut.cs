using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOut : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
