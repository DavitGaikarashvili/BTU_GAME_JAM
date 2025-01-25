using UnityEngine;
using TMPro;


public class PlayerMovement : MonoBehaviour
{



	public cubermovoment controller;
	public float RunSpeed = 40f;
	public float horizontalmove = 0f;
	bool jump = false;
	bool crouch = false;
	public tamashismenejeri tm;
	private void Update()
	{
		horizontalmove = Input.GetAxisRaw("Horizontal") * RunSpeed;
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		}
		else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}
	}
	private void FixedUpdate()
	{
		controller.Move(horizontalmove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("bushti"))
		{
			Destroy(other.gameObject);
			tm.bushtebi++;
		}
	}
}



