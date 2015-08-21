using UnityEngine;
using System.Collections;

public class CameraRotateLock : MonoBehaviour {

	Transform cameraTransform;
	Transform playerTransform;
	Rigidbody playerRigidbody;
	Vector3 relativePosition;

	public GameObject playerObject;

	// Use this for initialization
	void Start () {
		cameraTransform = GetComponent<Transform>();
		playerTransform = playerObject.GetComponent<Transform>();
		playerRigidbody = playerObject.GetComponent<Rigidbody>();
		relativePosition = cameraTransform.position - playerTransform.position;
	}
	
	// Update is called once per frame
	void Update () {
		cameraTransform.position = playerTransform.position + relativePosition;
	}
}
