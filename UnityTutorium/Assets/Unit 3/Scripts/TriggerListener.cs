using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerListener : MonoBehaviour
{
    public UnityEvent TriggerEnterResponse;
    public UnityEvent TriggerExitResponse;

    private void OnTriggerEnter(Collider other)
    {
        TriggerEnterResponse.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        TriggerExitResponse.Invoke();
    }
}
