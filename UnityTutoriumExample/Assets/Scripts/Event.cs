using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Event : ScriptableObject
{
    List<UnityEvent> _listeners = new List<UnityEvent>();

    public void AddListener(UnityEvent listener)
    {
        if (!_listeners.Contains(listener)) _listeners.Add(listener);
    }

    public void RemoveListener(UnityEvent listener)
    {
        _listeners.Remove(listener);
    }

    public void Invoke()
    {
        foreach (var listener in _listeners)
        {
            listener.Invoke();
        }
    }
}
