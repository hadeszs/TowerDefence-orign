using UnityEngine;
using System.Collections;
 
namespace TowerDefence {
	public class ChangeMode : MonoBehaviour {
		public GameObject MainCamera;
		public GameObject Player;
		public GameObject PlayerCamera;
		public GameObject aim;
        private GameObject wpcontainer;
		public bool Change;
		// Use this for initialization
		void Start () {
			Player=GameObject.Find("Player");
			PlayerCamera=Player.transform.GetChild(0).gameObject;
			MainCamera=GameObject.Find("Camera");
			Player.GetComponent<PlayerControl>().enabled=false;
			Player.GetComponent<Turret>().enabled=true;
			Player.GetComponent<TargetFinder>().enabled=true;
            Player.GetComponent<findAttackWp>().enabled = false;
            //wpcontainer = GameObject.Find("wp container");
            //wpcontainer.SetActive(false);
            Change =false;
			MainCamera.SetActive(true);
			PlayerCamera.SetActive(false);
            aim.SetActive(false);
		}
	
	// Update is called once per frame
		void Update () {
			if(Change){
                aim.SetActive(true);
                MainCamera.SetActive(false);
				PlayerCamera.SetActive(true);
				Player.GetComponent<PlayerControl>().enabled=true;
				Player.GetComponent<Turret>().enabled=false;
				Player.GetComponent<TargetFinder>().enabled=false;
				Player.GetComponent<TargetFinder>().range=0;
                Player.GetComponent<findAttackWp>().enabled = true;
                //wpcontainer.SetActive(true);
                
			}
			else{
                aim.SetActive(false);
                MainCamera.SetActive(true);
				PlayerCamera.SetActive(false);
				Player.GetComponent<PlayerControl>().enabled=false;
				Player.GetComponent<Turret>().enabled=true;
				Player.GetComponent<TargetFinder>().enabled=true;
                Player.GetComponent<findAttackWp>().enabled = false;
                Player.GetComponent<TargetFinder>().range=100;
                //wpcontainer.SetActive(false);
                
			}
		}
	}
}