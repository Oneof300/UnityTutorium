using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatVariable : ScriptableObject
{
    [SerializeField] float _value;

    public float Value => _value;
}
