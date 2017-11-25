using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AutoWalk : MonoBehaviour {
	public int speed = 10;

	public float maxLookAngle = 30.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Camera.main.transform.eulerAngles.x <= maxLookAngle || Camera.main.transform.eulerAngles.x >= 360-maxLookAngle) {
			transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
		}
	}

	public void OnTriggerEnter(Collider collide)
	{
		if (collide.gameObject.CompareTag ("TrophyTag")) {
			SceneManager.LoadScene("EndScene");
		}
	}
}
