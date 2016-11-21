using UnityEngine;
using System.Collections;

public class FirstScript : MonoBehaviour {
	public Vector3 moveDirection;
	public Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
		rigidBody.velocity = moveDirection;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += moveDirection;
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.CompareTag ("Paddle")) {
			moveDirection = new Vector3 (-moveDirection.x, 0, moveDirection.z);
		} else {
			moveDirection = new Vector3 (moveDirection.x, 0, -moveDirection.z);
		}

	}
}
