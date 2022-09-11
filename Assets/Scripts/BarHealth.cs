using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarHealth : MonoBehaviour
{
    [SerializeField] Slider _healhtBar;
    [SerializeField] private Player _player;

    private Coroutine _ñhangeValueBar;

    public void OnValueChanged(int value, int maxValue)
    {
        float valueNew =(float)value / maxValue;
        _ñhangeValueBar= StartCoroutine(ChangeValueBar(valueNew));
    }

    private void OnEnable()
    {
        _player.ChangedHealth += OnValueChanged;
    }

    private void OnDisable()
    {
        _player.ChangedHealth -= OnValueChanged;
    }

    private IEnumerator ChangeValueBar(float valueNew)
    {
        float runningTime = 0;

        while (_healhtBar.value != valueNew)
        {
            runningTime += Time.deltaTime;
            _healhtBar.value = Mathf.MoveTowards(_healhtBar.value, valueNew, runningTime);
            yield return null;
        }
    }
}
