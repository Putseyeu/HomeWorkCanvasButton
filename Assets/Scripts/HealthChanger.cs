using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthChanger : MonoBehaviour
{
    [SerializeField] private Button _increaseHealth;
    [SerializeField] private Button _downHealth;
    [SerializeField] private Player _player;

    private int _damage = 10;
    private int _treatment = 10;

    public void OnButtonClicUpHealth()
    {
        _player.TakeTreatment(_treatment);
    }

    public void OnButtonClicDownHealth()
    {
        _player.TakeDamage(_damage);
    }
}
