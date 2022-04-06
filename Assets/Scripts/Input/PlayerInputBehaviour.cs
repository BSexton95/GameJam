using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputBehaviour : MonoBehaviour
{
    private PlayerMovementBehaviour _playerMovement;

    void Awake()
    {
        _playerMovement = GetComponent<PlayerMovementBehaviour>();
    }

    void Update()
    {
        _playerMovement.MoveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        _playerMovement.MouseDirection = new Vector2(Input.GetAxisRaw("Mouse X"), 0).normalized;
    }
}
