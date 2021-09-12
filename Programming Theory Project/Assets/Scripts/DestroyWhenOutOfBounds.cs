using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenOutOfBounds : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        bool cond1 = gameObject.transform.position.x > 25;
        bool cond2 = gameObject.transform.position.x < -25;
        bool cond3 = gameObject.transform.position.y > 20;
        bool cond4 = gameObject.transform.position.y < -20;

        if (cond1 || cond2 || cond3 || cond4)
        {
            Destroy(gameObject);
        }
    }
}
