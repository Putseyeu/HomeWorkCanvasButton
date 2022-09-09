using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDownButton : MonoBehaviour
{
    [SerializeField] private Button _downHealth;
    [SerializeField] private Player _player;

    public void OnButtonClic()
    {
        _player.TakeDamage();
    }
}
