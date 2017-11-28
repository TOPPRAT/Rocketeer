using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {


	public GameObject pickupEffect;
	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player"))
		{
			Debug.Log("Picking Up Item");
			Pickup();
		}
	}

	void Pickup() {
		
		Instantiate(pickupEffect, transform.position, transform.rotation);

		Destroy(gameObject);
	}

}
