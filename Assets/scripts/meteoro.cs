using UnityEngine;
using System.Collections;

public class meteoro : MonoBehaviour {

	// Use this for initialization
	private float speed = 2f;
	public GameObject explosao;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 movement = new Vector2(0, - speed);
		GetComponent<Rigidbody2D> ().velocity = movement;


		if (transform.position.y < -5.5f) { 
			GameObject.Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.collider.tag == "balinha") {
			GameObject.Destroy (gameObject);
			GameObject exploded = Instantiate(explosao, transform.position, transform.rotation) as GameObject;
			GameObject.Destroy(exploded, 5f);
		}
		if (coll.collider.tag == "Player") {
			GameObject.Destroy (gameObject);
			GameObject exploded = Instantiate(explosao, transform.position, transform.rotation) as GameObject;
			GameObject.Destroy(exploded, 5f);
		}
	}
}
