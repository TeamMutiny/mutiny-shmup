using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private CharacterController playerController;
	
	public float speed;
	
	private Vector3 moveDirection;
	
	// Use this for initialization
	void Start () {
		moveDirection = new Vector3(0.0f,0.0f,0.0f);
		
		playerController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
	
		moveDirection *= speed;
		
		playerController.Move(moveDirection * Time.deltaTime);
		
		
	}
}
