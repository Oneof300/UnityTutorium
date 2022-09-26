using UnityEngine;
using UnityEngine.Events;

namespace UnityTutorium
{
    public class TriggerListener : MonoBehaviour
    {
        [SerializeField] UnityEvent TriggerEnterResponse;
        [SerializeField] UnityEvent TriggerExitResponse;

        void OnTriggerEnter(Collider other)
        {
            TriggerEnterResponse.Invoke();
        }

        void OnTriggerExit(Collider other)
        {
            TriggerExitResponse.Invoke();
        }
    }
}
