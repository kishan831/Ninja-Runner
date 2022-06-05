using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenScript : MonoBehaviour {

	private bool attackRight;
	private float attackSpeed = 6f;

	void Start () {
		transform.rotation = Quaternion.Euler (new Vector3(0f, 0f, 
			Random.Range(-45f, 45f)));

		if (transform.position.x > 0) {
			attackRight = false;
		} else {
			attackRight = true;
		}

		Invoke ("Deactivate", 5f);

	}

	void Update () {
		if (!attackRight) {
			// LEFT
			transform.position -= Vector3.right * attackSpeed * Time.deltaTime;
		} else {
			// RIGHT
			transform.position += Vector3.right * attackSpeed * Time.deltaTime;
		}
	}

	void Deactivate() {
		gameObject.SetActive (false);
	}
		
} // class











































