using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
	public GameObject asteroidExplosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private GameController gameController;

	void Awake(){
		GameObject gameControllerObj = GameObject.Find ("GameController");
		if (gameControllerObj != null) {
			gameController = gameControllerObj.GetComponent<GameController> ();
		}
	}
	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Boundary")) {
			return;
		}
		if (other.CompareTag("Player")){
			Debug.Log ("Hit Player");
			Instantiate (playerExplosion, transform.position,transform.rotation);
			gameController.GameOver ();
		}
		Instantiate (asteroidExplosion, transform.position,transform.rotation);
		gameController.AddScore (scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);

	}
}
