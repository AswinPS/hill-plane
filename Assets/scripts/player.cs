using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public Vector2 jump = new Vector2 (0, 300);
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			rb.velocity = Vector2.zero;
			rb.AddForce (jump);
		}
		Vector2 screenp = Camera.main.WorldToScreenPoint (transform.position);
		if (screenp.y > Screen.height || screenp.y < 0)
		{
			Die ();
		}

	
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		Die ();
	}
	void Die()
	{
		Application.LoadLevel (Application.loadedLevel);
	
	}
}
