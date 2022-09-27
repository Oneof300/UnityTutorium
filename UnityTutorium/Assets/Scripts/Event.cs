using System.Collections.Generic;
using UnityEngine;

namespace UnityTutorium
{
    [CreateAssetMenu]
    public class Event : ScriptableObject
    {
        public delegate void EventDelegate();

        List<EventDelegate> _listeners = new();

        public void AddListener(EventDelegate listener)
        {
            if (_listeners.Contains(listener)) return;
            _listeners.Add(listener);
        }

        public void RemoveListener(EventDelegate listener) =>
            _listeners.Remove(listener);

        public void Invoke()
        {
            Debug.Log(name + " has been invoked.");
            foreach (var listener in _listeners)
                listener();
        }
    }
}
