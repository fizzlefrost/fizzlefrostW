using UnityEngine;
using System.Collections;

public class CompleteCameraController : MonoBehaviour {

	public GameObject player;		//Public variable to store a reference to the player game object


	private Vector3 offset;			

	void Start () 
	{
		offset = transform.position - player.transform.position;
	}
	
	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;
	}
}
