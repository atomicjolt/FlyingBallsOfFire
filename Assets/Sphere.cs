using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		FlyAround ();
	}

	void FlyAround(){
		float x = Random.Range (-100, 100);
		float y = Random.Range (-100, 100);
		float z = Random.Range (-100, 100);
		gameObject.GetComponent<Rigidbody> ().AddForce(x, y, z);
	}
}
