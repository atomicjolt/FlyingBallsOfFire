using UnityEngine;
using System.Collections;

public class SetupMap : MonoBehaviour {

	public GameObject cylinder;
	public GameObject sphere;
	public int planeScale = 10;
	
	// Use this for initialization
	void Awake () {
		
		MeshCollider mesh = gameObject.GetComponent<MeshCollider>();
		CapsuleCollider cynMesh = cylinder.GetComponent<CapsuleCollider>();
		
		for (int i = 0; i<200; i++) {
			float x = Random.Range(mesh.sharedMesh.bounds.min.x * planeScale, 
			                       mesh.sharedMesh.bounds.max.x * planeScale);
			float z = Random.Range(mesh.sharedMesh.bounds.min.z * planeScale, 
			                       mesh.sharedMesh.bounds.max.z * planeScale);
			float y = Random.Range(cynMesh.bounds.min.y,
			                       cynMesh.bounds.max.y);
			
			GameObject cyn = Instantiate(cylinder, new Vector3(x, y, z), Quaternion.identity) as GameObject;

			GameObject sp = Instantiate(sphere, new Vector3(x, y + 1, z), Quaternion.identity) as GameObject;
			//sp.AddComponent();
			
		}
		
	}

}
