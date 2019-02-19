using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppManager : MonoBehaviour {


[Header("VARIABLES")]
[Tooltip("empty tile handy for resetting")]
//empty tile handy for resetting
public Button emptyTile;

//array of all the text from the tiles in the top row
public List<string> output; 

[Header("_______________________________________________________________________________")]
[Header("topGrid")]
[Tooltip("ref to the top grid space holder")]
//ref to the top grid space holder
public Button[] topGridSpace;

//ref for the tile object which contains the image and the text that will be added
[HideInInspector]
public List <Button> topGridTiles;

[Header("_______________________________________________________________________________")]
[Header("mainGrid")]
[Tooltip("array of grid spaces to be used for the main grid")]
//array of grid spaces to be used for the main grid
public Button[] mainGridSpace;

[Tooltip("array of Tiles that will go into the main grid")]
//array of Tiles that will go into the main grid
public Button[] mainGridTiles;



	// Use this for initialization
	void Start () {
		//initialize the TTS set the language we want to use
		TTSManager.SetLanguage (TTSManager.ENGLISH);
		//Put image into grid
		//gridSpace sprite property setting equal to new image
		for (int i = 0; i < mainGridTiles.Length; i++)
        {
			//each image into each gridspace
            mainGridSpace[i].GetComponentInChildren<Image>().sprite = 
			mainGridTiles[i].GetComponentInChildren<Image>().sprite;
			//each text into each gridspace
			mainGridSpace[i].GetComponentInChildren<Text>().text = 
			mainGridTiles[i].GetComponentInChildren<Text>().text;
        }
		
	}

void Update(){

		//Putting the grid squares into the topGridSpace
		//if nothing selected these will be empty
		for (int i = 0; i < topGridTiles.Count; i++)
        {
			//get the top grid space and fill with the tile image
            topGridSpace[i].GetComponentInChildren<Image>().sprite = 
            topGridTiles[i].GetComponentInChildren<Image>().sprite;

            //get the top grid space and fill with the tile text
            topGridSpace[i].GetComponentInChildren<Text>().text = 
            topGridTiles[i].GetComponentInChildren<Text>().text;
        }
		
	}

	//when you click the button tile, push tile into the array
	public void AddButton(Button tile){
		//add tile to the array	
       topGridTiles.Add(tile);				
		
	}

	//function to remove current tile in the top grid
	public void RemoveButton(int curTile){
		//remove from the top tiles array 
		//fillgridspace is a ref to the tile obj
		//current tile is the ref to the position of the button in the array
		//so we know which one has been clicked on
	
       topGridTiles.RemoveAt(curTile);	
	   
	   //replace the tile clicked with the empty placeholder tile image
	   //
        topGridSpace[topGridTiles.Count].GetComponentInChildren<Image>().sprite = 
		emptyTile.GetComponentInChildren<Image>().sprite;
		//do the same for the text
		topGridSpace[topGridTiles.Count].GetComponentInChildren<Text>().text = 
		emptyTile.GetComponentInChildren<Text>().text;
		
	}

	public void PlaySoundButton(){
		//Empty all at the start
		output.Clear();
		//loop tru the tiles in the top row and take all the strings from them
		for (int i = 0; i < topGridTiles.Count; i++){
			output.Add(topGridTiles[i].GetComponentInChildren<Text>().text);
		}		
		//tts goes here
		//TTSManager.Speak("Hello World", true);
		Debug.Log(string.Join(" ", output.ToArray()));
		//TTSManager.Speak(string.Join(" ", output.ToArray()));
		
	}
}
