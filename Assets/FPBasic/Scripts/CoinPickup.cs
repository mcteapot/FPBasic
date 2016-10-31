using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other) {
		Debug.Log("Coin is picked up");
		//Destroy(other.gameObject);
		//Debug.Log("TRIGGER ENTERED");
		//doorAnimator.SetTrigger("open");

	}
}
