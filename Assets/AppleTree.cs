using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {

	// Prefab for instantiating apples
	public GameObject applePrefab;

	// Speed at which the AppleTree moves in meters/second

	public float speed = 1f;

	// Distance where AppleTree turns around
	public float leftAndRightEdge = 10f;

	// Chance that the AppleTree will change directions
	public float chanceToChangeDirections = 0.1f;

	// Rate at which the apples will be instantiated
	public float secondsBetweenAppleDrops = 1f;

	// Use this for initialization drop apples every second
	void Start () {
	
	}
	
	// Update is called once per frame basic movement and changing direction
	void Update () {
		// basic movement
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
	
	}
}
