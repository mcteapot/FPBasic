using UnityEngine;
using System.Collections;

public class DoorOpener : MonoBehaviour {

	public Transform door;

	private float startPos;
	public float endPos;

	// Use this for initialization
	void Start () {
		startPos = door.position.z;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);
		Debug.Log("TRIGGER ENTERED");
		door.position = new Vector3(door.position.x, door.position.y, endPos);

	}

	void OnTriggerExit(Collider other) {
		Debug.Log("TRIGGER EXIT");

		door.position = new Vector3(door.position.x, door.position.y, startPos);
	}
}
