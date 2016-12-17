using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour {

	void OnCollisionEnter( Collision coll ) {                             
		// Find out what hit this basket
		GameObject collidedWith = coll.gameObject;                          
		if ( collidedWith.tag == "Apple" ) {                                
			Destroy( collidedWith );
		}
	}
}