using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private GameObject _playerObject;
    private Player _player;

    private void Start()
    {
        _animator = GetComponent<Animator>();

        _playerObject = GameObject.Find("Player");

        _player = _playerObject.GetComponent<Player>();
    }

    private void Update()
    {
        if (_player.Velocity.x != 0)
            _animator.SetBool("IsRun", true);
        else
            _animator.SetBool("IsRun", false);
    }
}
