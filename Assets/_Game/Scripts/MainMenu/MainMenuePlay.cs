using UnityEngine;
using System.Collections;

public class MainMenuePlay : MonoBehaviour {

    // Use this for initialization
	void Start () {
		GameObject.Find("MainMenu").SetActive(true);
		GameObject.Find("OptionMenu").SetActive(false);
	}

	void OnMouseEnter()
	{
		GetComponent<Renderer>().material.color = Color.blue;
	}
	
	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = Color.white;
	}
	
	void OnMouseUp()
	{

		Application.LoadLevel("Game");
	}
}
