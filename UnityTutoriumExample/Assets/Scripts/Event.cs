using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Event : ScriptableObject
{
    public delegate void EventDelegate();

    List<EventDelegate> _listeners = new List<EventDelegate>();

    public void AddListener(EventDelegate listener)
    {
        if (!_listeners.Contains(listener)) _listeners.Add(listener);
    }

    public void RemoveListener(EventDelegate listener)
    {
        _listeners.Remove(listener);
    }

    public void Invoke()
    {
        foreach (var listener in _listeners)
        {
            listener();
        }
    }
}
