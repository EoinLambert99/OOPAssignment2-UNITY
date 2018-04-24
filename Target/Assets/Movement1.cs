using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour {
	[SerializeField]
	Transform[] wayPoints;
	int currentWaypoint = 0;
	Rigidbody rigidB;

	[SerializeField]
	float moveSpeed = 5;


	// Use this for initialization
	void Start () {
		rigidB = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		Movement ();
	}

	void Movement()
	{
		if (Vector3.Distance (transform.position, wayPoints [currentWaypoint].position) < .25f) {
			currentWaypoint += 1;
			currentWaypoint = currentWaypoint % wayPoints.Length;
		}
		Vector3 _dir = (wayPoints [currentWaypoint].position - transform.position).normalized;
		rigidB.MovePosition (transform.position + _dir * moveSpeed * Time.deltaTime);
	}
}

