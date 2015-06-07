using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour
{
	float timer;
	Vector3 startPos;
	Vector3 endPos;

	void Start()
	{
		RandomPosition();
	}

	void RandomPosition()
	{
		timer = Time.time;
		startPos = transform.position;
		endPos = new Vector3(Random.Range(-50f, 50f), Random.Range(-100f, 100f), 0);
	}
	void Update()
	{
		transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward,
			Camera.main.transform.rotation * Vector3.up);
	}
}