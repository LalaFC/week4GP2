using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    private InputManager _inputManager;
    private Vector3 direction; 
    private Rigidbody _rigidbody;
    private Transform _camera;

    private void Awake()
    {
        _inputManager = GetComponent<InputManager>();
        _rigidbody = GetComponent<Rigidbody>();
        _camera = Camera.main.transform;
    }

    public void HandleAllMvment()
    {
        HandleMovement();
        HandleRotation();
    }

    private void HandleMovement () 
    {

    } 
    private void HandleRotation () 
    {

    }
}
