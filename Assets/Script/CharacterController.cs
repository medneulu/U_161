using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpForce = 5f;
    private Rigidbody2D _Rigidbody2D;
    private Animator _animator;

    private bool grounded;
    private bool started;
    private void Awake()
    {
        _Rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        grounded = true;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (started && grounded)
            {
                _animator.SetTrigger("Jump");
                grounded = false;

            }
            else
            {
                _animator.SetBool("GameStarted", true);
                started = true;
            }
        }
    }
}
