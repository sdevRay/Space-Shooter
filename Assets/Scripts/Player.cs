using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody rb;
	public float speed;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.velocity = movement * speed;
	}
}
