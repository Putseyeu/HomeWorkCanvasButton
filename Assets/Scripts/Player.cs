using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Player : MonoBehaviour
{    
    private int _maxHeal = 100;
    private int _heal = 100;    
    private int _minHeal = 0;

    public event UnityAction<int, int> ChangedHealth;

    private void Start()
    {
        _heal = _maxHeal;
        ChangedHealth?.Invoke(_heal, _maxHeal);
    }

    public void TakeDamage(int damage)
    {
        _heal = Mathf.Clamp(_heal- damage, _minHeal, _maxHeal);
        ChangedHealth?.Invoke(_heal, _maxHeal);
    }

    public void TakeTreatment(int treatment)
    {
        _heal = Mathf.Clamp(_heal + treatment, _minHeal, _maxHeal);
        ChangedHealth?.Invoke(_heal, _maxHeal);
    }
}
