using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneRopeTip : MonoBehaviour {

	public GameObject currentLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (currentLoad != null) {
			Rigidbody2D physicsBody = currentLoad.gameObject.GetComponent<Rigidbody2D> ();
			physicsBody.isKinematic = true;
			currentLoad.gameObject.transform.position = this.gameObject.transform.position;
		}

		if(currentLoad != null && Input.GetKey(KeyCode.S)) {
			Rigidbody2D physicsBody = currentLoad.gameObject.GetComponent<Rigidbody2D> ();
			physicsBody.isKinematic = false;
			//physicsBody.velocity = this.gameObject.GetComponent<Rigidbody2D>().velocity;
			currentLoad = null;
		}
	}
}
