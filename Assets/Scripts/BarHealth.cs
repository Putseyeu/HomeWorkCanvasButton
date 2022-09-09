using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarHealth : MonoBehaviour
{
    [SerializeField] Slider _healhtBar;
    [SerializeField] private Player _player;

    private void Update()
    {
        
    }

    public void OnValueChanged(int value, int maxValue)
    {
        _healhtBar.value = (float)value / maxValue;
    }

    private void OnEnable()
    {
        _player.ChangedHealth += OnValueChanged;
    }

    private void OnDisable()
    {
        _player.ChangedHealth -= OnValueChanged;
    }
}
