using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerListener : MonoBehaviour
{
    public UnityEvent TriggerEnterResponse;
    public UnityEvent TriggerExitResponse;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
        TriggerEnterResponse.Invoke();
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
        TriggerExitResponse.Invoke();
    }
}
