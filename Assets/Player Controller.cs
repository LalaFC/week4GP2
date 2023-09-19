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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MoveForward();
        }
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        PlayerAnim.SetBool("isRunning",true);
    }
}
