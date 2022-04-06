using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTextBehaviour : MonoBehaviour
{
    [SerializeField]
    private Text _healthText;
    [SerializeField]
    private HealthBehaviour _health;


    // Update is called once per frame
    void Update()
    {
        float health = _health.Health;

        if (health < 0)
            health = 0;

        _healthText.text = "Health: " + health;
    }
}
