using UnityEngine;
using System.Collections;

public class TeleportFromFall : MonoBehaviour {

	public float yLevel;
	Transform objTransform;
	Rigidbody objRigidbody;
	public Vector3 teleportPosition;

	// Use this for initialization
	void Start () {
		objTransform = GetComponent<Transform>();
		objRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate () {
		// Debug.Log("Y = " + objTransform.transform.position.y);
		if (objTransform.transform.position.y < yLevel) {
			objTransform.transform.position = teleportPosition;
			objRigidbody.velocity = new Vector3(0,0,0);

		}
	}
}
