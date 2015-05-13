using UnityEngine;
using System.Collections;

public abstract class actor : MonoBehaviour {
	public float move_time = .01f;
	public LayerMask blockingLayer;

	private BoxCollider2D box_collider;
	private Rigidbody2D rb2;
	private float inverse_move_time;
	// Use this for initialization
	protected virtual void Start () {
		box_collider = GetComponent<BoxCollider2D> ();
		rb2 = GetComponent<Rigidbody2D> ();
		inverse_move_time = 1f / move_time;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
