using UnityEngine;
using System.Collections;

public class ro : MonoBehaviour {

    public GameObject effect;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {


        GameObject firework = Instantiate(effect) as GameObject;

        firework.transform.position = transform.position;

        Destroy(gameObject);
        Destroy(firework, 7);
    }
}
