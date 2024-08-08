using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class PlayerController : MonoBehaviour
{
    public FixedJoystick _joystick;
    public float _moveSpeed = 5f;

    private Rigidbody _rigidbody;

    [SerializeField] Animator _animator;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetBool("isWalking", true);
        }
        else
            _animator.SetBool("isWalking", false);
    }
}