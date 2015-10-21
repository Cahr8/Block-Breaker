using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {
	public Rigidbody projectile;
	void Update() {
		if (Input.GetButtonDown("Fire2")) {
			Rigidbody clone;
			clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.forward * 0);
		}
	}
}