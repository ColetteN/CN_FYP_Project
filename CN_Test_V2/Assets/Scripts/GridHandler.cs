using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridHandler : MonoBehaviour {

	//Image (public)
	//Public so we can drag and drop in inspector
	//ref to the image only
	public Sprite[] imageForGrid;
	public string[] textForGrid;

	//Grid (public)
	//Public so we can drag and drop in inspector
	//ref to the grid only
	//the UI image element
	public Button[] gridSpace;

	// Use this for initialization
	void Start () {
		//Put image into grid
		//gridSpace sprite property setting equal to new image
		for (int i = 0; i < imageForGrid.Length; i++)
        {
			//each image into each gridspace
            gridSpace[i].GetComponentInChildren<Image>().sprite = imageForGrid[i];
			//each text into each gridspace
			gridSpace[i].GetComponentInChildren<Text>().text = textForGrid[i];
        }
		
	}
	
	
}



