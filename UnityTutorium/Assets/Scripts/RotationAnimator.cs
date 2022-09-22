using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAnimator : MonoBehaviour
{
    public float speed;
    public Vector3 vector = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vector * speed * Time.deltaTime, Space.Self);
    }
}
