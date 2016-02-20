using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

	public GameObject sphere;
	public int numberOfCubes;
	public int min, max;

	void Start () {
		PlaceSpheres ();
	}
	
	void PlaceSpheres(){
		for (int i = 0; i < numberOfCubes; i++) {
			Instantiate (sphere, GeneratedPosition(), Quaternion.identity);
		}
	}

	Vector3 GeneratedPosition(){
		int x, y, z;
		x = UnityEngine.Random.Range (min, max);
		y = UnityEngine.Random.Range (min, max);
		z = UnityEngine.Random.Range (min, max);
		return new Vector3 (x, y, z);
	}
}