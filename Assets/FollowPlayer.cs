using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	
	public Transform player;
	float zOffset;
	
	// Use this for initialization
	void Start () {
	
		zOffset = transform.position.z - player.position.z;
		
	}
	
	// Update is called once per frame
	void Update () {
	
		float playerZ = player.position.z;
		float cameraZ = transform.position.z;
		
		
		transform.Translate (0, 0, playerZ - cameraZ + zOffset);
		
	}
}
