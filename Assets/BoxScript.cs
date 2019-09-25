using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour {

	public GameObject box;

	// Use this for initialization
	void Start () {
		
	}


	private void OnMouseDown () {
		// luo 8 boxia perustuen tämän sijaintiin
		// joiden scale on tämän scale / 2 (joka akselilla)
		// sijoita luodut kuution muotoon
		// kun tehty ja setit o settei, tuhoa tämä objekti
		Vector3 pos = gameObject.transform.position;
		Quaternion rot = gameObject.transform.rotation;

		int n = 2;

		box.transform.localScale = gameObject.transform.localScale / n;
		//box.GetComponent<Rigidbody> ().isKinematic = true;



		// "kerrokset", y?
		for (int i = 0; i < n; i++) {
			float y = pos.y + (i * box.transform.localScale.y) - (gameObject.transform.localScale.y / 2);

			// "x"
			for (int j = 0; j < n; j++) {
				float x = pos.x + (j * box.transform.localScale.x) - (gameObject.transform.localScale.x / 2);

				// "z"
				for (int k = 0; k < n; k++) {
					float z = pos.z + (k * box.transform.localScale.z) - (gameObject.transform.localScale.z / 2);

					Vector3 new_pos = new Vector3 (x, y, z);
					Instantiate (box, new_pos, rot);
				}
			}
		}

		Destroy (gameObject);

	}
}
