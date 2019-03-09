using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScreen : MonoBehaviour {
	
	// Update is called once per frame
	public void ChangeScreenTo (string sceneToChangeTo) {
		SceneManager.LoadScene(sceneToChangeTo);
		
	}
}
