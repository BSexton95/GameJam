using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitEmitterBehaviour : MonoBehaviour
{
    [SerializeField]
    private SpitBehaviour _spitRef;
    [SerializeField]
    private float _spitForce;
    [SerializeField]
    private GameObject _owner;

    public void Spit()
    {
        GameObject spit = Instantiate(_spitRef.gameObject, transform.position, transform.rotation);
        SpitBehaviour spitBehaviour = spit.GetComponent<SpitBehaviour>();
        spitBehaviour.OwnerTag = _owner.tag;

        spitBehaviour.Rigidbody.AddForce(transform.forward * _spitForce, ForceMode.Impulse);
    }
}
