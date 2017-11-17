using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {


	public float speed = 0.02f;
	public float floatDistance = 1f;
	private float maxY;
	private float minY;
	private float originalY;

	// Use this for initialization
	void Start () {

		// Randomising direction of floating
		if (Random.Range(0, 2) == 1) {
			speed = -speed;
		}

		// Getting distance of floating
		maxY = transform.position.y + floatDistance;
		minY = transform.position.y - floatDistance;
	}
	

	// Update is called once per frame
	void Update () {
		// Changing direction of movement
		if (transform.position.y >= maxY)
			speed = -speed;
		else if (transform.position.y <= minY)
			speed = Mathf.Abs(speed);

		this.transform.position = new Vector3 (transform.position.x, transform.position.y + speed, transform.position.z);
	}
}
