using UnityEngine;
using System.Collections;

public class PlayerMovementControl : MonoBehaviour {
	
	public float xSpeed = 1.0f;
	public float ySpeed = 1.0f;
	public float zSpeed = 1.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdate () {
		
		float xMove = Input.GetAxis ("Horizontal") * xSpeed * Time.deltaTime;
		float yMove = Input.GetAxis ("Vertical") * ySpeed * Time.deltaTime;
		float zMove = zSpeed * Time.deltaTime;
		
		transform.Translate (xMove, yMove, zMove);
		//rigidbody.MovePosition(new Vector3(transform.position.x + xMove, transform.position.y + yMove, transform.position.z + zMove));
	}
	
	
}
