using UnityEngine;
using System.Collections;

public class Cylinder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Renderer renderer = gameObject.GetComponent<Renderer>();
		renderer.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
