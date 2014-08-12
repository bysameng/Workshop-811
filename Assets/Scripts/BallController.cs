using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public CameraFollower cFollower;

	// Use this for initialization
	void Start () {
		// Debug.Log("please look at me in my eye! i love you");
	}

	
	// Update is called once per frame
	void Update () {
		//hey he did this thing with the things????

		Vector3 movement;
		movement = new Vector3(0f, 0f, 0f);
		//movement = Vector3.zero

		if (Input.GetKey(KeyCode.RightArrow)){
			movement.x = 10f;
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			movement.x = -10f;
		}

		if (Input.GetKeyDown(KeyCode.Space)){
			rigidbody.isKinematic = false;
			rigidbody.useGravity = true;
			rigidbody.AddForce(new Vector3(0, 0, 3000f));
		}

		//we're modulating this movement by the framerate time
		transform.position += movement * Time.deltaTime;
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Pin"){
			cFollower.following = false;
		}
	}
}
