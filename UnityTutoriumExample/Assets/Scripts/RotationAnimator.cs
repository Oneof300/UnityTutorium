using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAnimator : MonoBehaviour
{
    [SerializeField] FloatVariable _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // deltaTime: Zeit in Sekunden, die seit dem letzten Frame vergangen ist
        transform.Rotate(new Vector3(-5, 10, 0) * _speed.Value * Time.deltaTime);
    }
}
