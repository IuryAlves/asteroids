using UnityEngine;
using System.Collections;

public class Plane : MonoBehaviour {

	private Renderer rend;
	private float scrollSpeed = 0.5F;

	void Start () {
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		float offset = Time.time * scrollSpeed;
		rend.material.mainTextureOffset = new Vector2 (0, - offset);
	}

}
