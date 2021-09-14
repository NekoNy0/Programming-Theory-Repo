using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    [SerializeField] private float speed = 1;

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.localPosition += gameObject.transform.TransformDirection(speed, 0, 0);
    }
}
