using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
	void OnTriggerStay(Collider col)
	{
		if (col.tag == "Player")
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				col.gameObject.GetComponent<Fonarik>().Energy += 25;
				Destroy(gameObject);
			}
		}
	}
}
