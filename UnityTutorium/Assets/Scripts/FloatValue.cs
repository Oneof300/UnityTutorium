using UnityEngine;

namespace UnityTutorium
{
    [CreateAssetMenu]
    public class FloatValue : ScriptableObject
    {
        [SerializeField] float _value;
        [SerializeField] Event _onChanged;

        public float Value
        {
            get => _value;
            set
            {
                if (_value == value) return;
                _value = value;
                _onChanged.Invoke();
            }
        }

        void OnValidate()
        {
            if (!_onChanged) return;
            _onChanged.Invoke();
        }
    }
}
