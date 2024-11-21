using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    

    [SerializeField] private float _jumpForce;
    [SerializeField] private KeyCode _jumpKey;

    [SerializeField] private LayerMask groundLayerMask;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform leftWallCheck;
    [SerializeField] private Transform rightWallCheck;
    [SerializeField] private float overlapRadius;
    private bool _isTouchingLeftWall;
    private bool _isTouchingRightWall;

    private Rigidbody2D _rb;
    private bool _isGrounded;

    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer _sr;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        Jump();
        CheckGround();
    }


    private void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(moveX * _speed, _rb.velocity.y);
        if (moveX != 0 && moveX < 0)
        {

            animator.Play("Running");
            _sr.flipX = true;
        }
        else if ((moveX != 0 && moveX > 0))
        {
            animator.Play("Running");
            _sr.flipX = false;
        }
        else animator.Play("Idle");
    }

    private void Jump()
    {
        if (Input.GetKeyDown(_jumpKey) & _isGrounded)
        { 
        _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }
    private void CheckGround()
    {
        _isGrounded = Physics2D.OverlapCircle(groundCheck.position, overlapRadius, groundLayerMask);
        Debug.Log($"_isGround: {_isGrounded}");
    }


    private void IsTouchingLeftWall()
    {
        _isTouchingLeftWall = Physics2D.OverlapCircle(leftWallCheck.position, overlapRadius, groundLayerMask);

    }
    private void IsTouchingRightWall()
    {
        _isTouchingRightWall = Physics2D.OverlapCircle(rightWallCheck.position, overlapRadius, groundLayerMask);

    }
}
