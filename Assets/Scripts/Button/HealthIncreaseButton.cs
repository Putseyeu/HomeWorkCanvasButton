using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthIncreaseButton : MonoBehaviour
{
    [SerializeField] private Button _increaseHealth;
    [SerializeField] private Player _player;

    public void OnButtonClic()
    {
        _player.TakeTreatment();
    }
}
