using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
	public GameObject asteroidExplosion;
	public GameObject playerExplosion;

	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Boundary")) {
			return;
		}
		if (other.CompareTag("Player")){
			Debug.Log ("Hit Player");
			Instantiate (playerExplosion, transform.position,transform.rotation);
		}
		Instantiate (asteroidExplosion, transform.position,transform.rotation);

		Destroy (other.gameObject);
		Destroy (gameObject);

	}
}
