using UnityEngine;
using TMPro;
using System;


public class PlayerMovement : MonoBehaviour
{



	public cubermovoment controller;
	public float RunSpeed = 40f;
	public float horizontalmove = 0f;
	bool jump = false;
	tamashismenejeri tm;
	[SerializeField] private float gravity = 1.5f;
	[SerializeField] private float balloonforce = 0.1f;
	private Rigidbody2D rb;
	private GameObject lastbushti;
	private Animator anim;
	private void Start()
	{
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
		tm = GameObject.FindWithTag("manager").GetComponent<tamashismenejeri>();
	}

	private void Update()
	{
		rb.gravityScale = gravity - balloonforce * tm.getGaberili();
		horizontalmove = Input.GetAxisRaw("Horizontal") * RunSpeed;
		anim.SetFloat("horizontal", Math.Abs(Input.GetAxisRaw("Horizontal")));
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
	}
	private void FixedUpdate()
	{
		controller.Move(horizontalmove * Time.fixedDeltaTime, jump);
		jump = false;
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("bushtis_yuti") && lastbushti != other.gameObject)
		{
			lastbushti = other.gameObject;
			other.gameObject.SetActive(false);
			Destroy(other.gameObject);
			tm.bushtebi++;
		}
	}
}



