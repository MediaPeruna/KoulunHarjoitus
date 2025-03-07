using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SimpleMovement : MonoBehaviour
{
	private float horizontal;
	public float speed = 8f;
	private float jumpingPower = 16f;
	private bool isFacingRight = true;
	
	[SerializeField] private Rigidbody2D rb;
	[SerializeField] private Transform groundCheck;
	[SerializeField] private LayerMask groundLayer;
	
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		horizontal = Input.GetAxisRaw("Horizontal");
		
		if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 )
		{

		}
		else
		{

		}
		
		if (Input.GetButtonDown("Jump") && IsGrounded())
		{
			rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower);
		}
	
	
		if (Input.GetButtonDown("Jump") && rb.linearVelocity.y > 0f)
		{
			rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
		}
		
	
	
		Flip();
    }
	
	private void FixedUpdate()
	{
		rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
	}
	
	private bool IsGrounded()
	{
		return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
	}
	
	private void Flip()
	{
		if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
		{
			isFacingRight = !isFacingRight;
			Vector3 localScale = transform.localScale;
			localScale.x *= -1f;
			transform.localScale = localScale;
		}
	}
	
}