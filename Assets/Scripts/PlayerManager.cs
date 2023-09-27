using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance { get; private set; }

    public GameObject player;
    public InputManager inputManager;
    public PlayerLocomotion locomotion;
    public Rigidbody _rigidbody;


    public float mvmtSpeed;
    public float rotSpeed;

    private void Awake()
    {
        if (instance != null && instance != this) { Destroy(this); }
        else { instance = this; }
        inputManager = player.GetComponent<InputManager>();
        locomotion = player.GetComponent<PlayerLocomotion>();
    }

    // Update is called once per frame
    void Update()
    {
        inputManager.HandleAllInput();
    }

    private void FixedUpdate()
    {
        locomotion.HandleAllMvment();
    }
}
