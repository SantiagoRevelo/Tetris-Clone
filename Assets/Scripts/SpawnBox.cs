using UnityEngine;
using System.Collections;

public class SpawnBox : MonoBehaviour {

	public GameObject[] boxList;
	public float CurentVelocity = 0.25f;

	// Use this for initialization
	void Start () {
		SpawnNewBox ();
	}
	
	// Update is called once per frame
	public void SpawnNewBox() {
		int i = Random.Range (0, boxList.Length);
		Instantiate (boxList [i], transform.position,  Quaternion.identity);
	}
}
