using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AutoWalk : MonoBehaviour {
	public int speed = 10;

	public LevelManager lvlManager;

	private bool canWalk = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			canWalk = !canWalk;
		}
		if (canWalk) {
			transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
		}
	}

	public void OnTriggerEnter(Collider collide)
	{
		if (collide.gameObject.CompareTag ("TrophyTag")) {
			lvlManager.LoadNextLevel ();
		}
	}
}
