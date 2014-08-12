using UnityEngine;
using System.Collections;

public class CameraFollower : MonoBehaviour {

	public GameObject followObject;
	public bool following = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (following){
			transform.position = 
				followObject.transform.position + new Vector3(0, 1f, -5f);
		}

	}
}
