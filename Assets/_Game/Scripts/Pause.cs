using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
	public GameObject Menu;

	// Use this for initialization
	void Start () {
	
	}
	
	public void Click()
	{
		Menu.SetActive(false);
		Time.timeScale=1;
	}
	
}
