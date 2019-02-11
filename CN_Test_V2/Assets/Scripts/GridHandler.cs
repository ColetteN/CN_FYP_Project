using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridHandler : MonoBehaviour {

	//Image (public)
	//Public so we can drag and drop in inspector
	//ref to the image only
	public Sprite[] testImage;

	//Grid (public)
	//Public so we can drag and drop in inspector
	//ref to the grid only
	//the UI image element
	public Image[] gridSpace;

	// Use this for initialization
	void Start () {
		//Put image into grid
		//gridSpace sprite property setting equal to new image
		for (int i = 0; i < testImage.Length; i++)
        {
			//each image into each gridspace
            gridSpace[i].sprite = testImage[i];
        }
	}
	
	
}



