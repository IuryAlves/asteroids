using UnityEngine;
using System.Collections;

public class balinha : MonoBehaviour {

	// Use this for initialization
	private float speed = 6f;
	public GameObject shoot;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
		Shoot ();
		if (transform.position.y > 5.5f) {
			GameObject.Destroy(gameObject);
		}
	}

	void Shoot(){
		Instantiate(shoot, transform.position, transform.rotation);
	}

}
