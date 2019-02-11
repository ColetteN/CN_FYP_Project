using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInputManager : MonoBehaviour {

	public void ClickButton(Text buttonText){
		Debug.Log(buttonText.text);
	}
}
