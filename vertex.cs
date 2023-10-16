using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertex : MonoBehaviour
{
	private Animator ctrlr;
	
	// Start is called before the first frame update
	void Start()
	{
		ctrlr = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update()
	{
		float vel = Input.GetAxisRaw("Horizontal")*Time.deltaTime*3;
		
		transform.Translate(new Vector3(vel, 0f, 0f), Space.World);
		
		if (vel > 0)
		{
			ctrlr.SetInteger("state", 1);
			
			transform.eulerAngles = new Vector3(0, 90, 0);
		}
		
		else if (vel < 0)
		{
			ctrlr.SetInteger("state", 1);
			
			transform.eulerAngles = new Vector3(0, 270, 0);
		}
		
		else
		{
			ctrlr.SetInteger("state", 0);
		}
	}
}