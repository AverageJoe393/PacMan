using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCreator : MonoBehaviour {

	public Rigidbody coin; 

	void Start () {
		for (int i = 0; i < 10; i++) {
			Vector3 pos = new Vector3 (Random.Range(-9f, 9f), 0.6f, Random.Range(-9f, 9f));
		//Vector3 rotation = new Vector3 (15f, 30f, 45f);
		Rigidbody coinClone = (Rigidbody)Instantiate (coin, pos, transform.rotation);
				}
	}


}
