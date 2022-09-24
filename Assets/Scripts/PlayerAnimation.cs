using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private Player _player;

    private const string IsRun = "IsRun";

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _player = GetComponent<Player>();
    }

    private void Update()
    {
        _animator.SetBool(IsRun, _player.Velocity.x != 0);
    }
}
