using UnityEngine;
using System.Collections;

public class HandAttack : MonoBehaviour {


	public Animator handAnim;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Debug.Log("Pressed left click.");

			handAnim.SetTrigger("attack");
		}


	}
}
