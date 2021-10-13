using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript2 : MonoBehaviour
{
    public float width = 20;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-4 * Time.deltaTime, 0, 0);
        if (transform.position.x <= -1 * width) {
            transform.Translate(width, 0, 0);
        }
    }
}
