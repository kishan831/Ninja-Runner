using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaScript : MonoBehaviour {

	public GameObject shuriken;

	public float moveSpeed = 5f;
	private float cameraY;

	private bool attackedPlayer;

	void Start () {
		cameraY = Camera.main.transform.position.y - 10f;
	}

	void Update () {
		Move ();
		Deactivate ();
	}

	void Move() {
		Vector3 temp = transform.position;
		temp.y -= moveSpeed * Time.deltaTime;
		transform.position = temp;

		if (transform.position.y < 0) {
			// WHEN THE NINJA REACHES MIDDLE OF THE SCREEN
			if(!attackedPlayer) {
				// IF WE ARE IN THE MIDDLE OF THE SCREEN
				// AND WE DID NOT ATTACK THE PLAYER
				attackedPlayer = true;

				Instantiate (shuriken, transform.position, Quaternion.identity);

			}
		}

	}

	void Deactivate() {
		if (transform.position.y < cameraY) {
			gameObject.SetActive (false);
		}
	}


} // class












































