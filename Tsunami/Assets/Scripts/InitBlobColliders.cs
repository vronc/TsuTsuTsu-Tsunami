using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBlobColliders : MonoBehaviour
{
	private SphereCollider m_collider;
	private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
		for (int i=0 ; i<4 ; i++) {
			// AddComponent creates the object and links it to the game object:
			GameObject child = new GameObject();
			child.transform.parent = this.gameObject.transform;
			m_collider = child.gameObject.AddComponent<SphereCollider>();
			rb = child.gameObject.AddComponent<Rigidbody>();
			int j = i%2;
			m_collider.center = new Vector3( -0.05f+0.1f*Random.value, 0, 0.05f+0.1f*Random.value ); // the center must be in local coordinates
			m_collider.radius = 0.2f;
		}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
