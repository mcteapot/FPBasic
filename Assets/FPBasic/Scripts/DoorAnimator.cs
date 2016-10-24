using UnityEngine;
using System.Collections;

public class DoorAnimator : MonoBehaviour {

	public Animator doorAnimator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);
		Debug.Log("TRIGGER ENTERED");
		doorAnimator.SetTrigger("open");

	}
}
