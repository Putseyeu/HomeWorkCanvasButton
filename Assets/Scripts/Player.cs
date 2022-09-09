using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Player : MonoBehaviour
{    
    private int _maxHeal = 100;
    private int _heal = 100;    
    private int _minHeal = 0;
    private int _damage = 10;
    private int _treatment = 10;

    public event UnityAction<int, int> ChangedHealth;

    private void Start()
    {
        _heal = _maxHeal;
        ChangedHealth?.Invoke(_heal, _maxHeal);
    }

    public void TakeDamage()
    {
        if (_heal > _minHeal)
        {
            _heal -= _damage;
            ChangedHealth?.Invoke(_heal, _maxHeal);
        }
    }

    public void TakeTreatment()
    {
        if (_heal < _maxHeal)
        {
            _heal += _treatment;
            ChangedHealth?.Invoke(_heal, _maxHeal);
        }
    }
}
