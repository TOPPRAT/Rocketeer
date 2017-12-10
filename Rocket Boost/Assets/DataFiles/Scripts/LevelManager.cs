using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadNextLevel() {
		if (SceneManager.GetActiveScene ().name == "EndScene") {
			SceneManager.LoadScene (1);
		} else {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}
}
