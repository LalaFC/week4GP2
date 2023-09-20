using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator PlayerAnim;
    [Range(0, 15)]
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            MoveForward();
        }
        else
        {
            StopMvment();
        }
    }

    void MoveForward()
    {
        PlayerAnim.SetBool("isRunning",true);
    }
    void StopMvment()
    {
        PlayerAnim.SetBool("isRunning", false);
    }
}
