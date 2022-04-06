using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitActionBehaviour : MonoBehaviour
{
    [SerializeField]
    private SpitEmitterBehaviour _gun;
    [SerializeField]
    private float _spitCoolDown;
    private float _spitTimer;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _gun.Spit();
        }
    }
}
