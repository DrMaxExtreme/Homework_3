using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
            _animator.SetBool("IsRun", true);
        else
            _animator.SetBool("IsRun", false);
    }
}
