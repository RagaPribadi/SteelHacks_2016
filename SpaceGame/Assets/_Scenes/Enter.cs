using UnityEngine;
using System.Collections;

public class Enter : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			Application.LoadLevel (1);
		}
	}
}
