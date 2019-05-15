using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBlobColliders2 : MonoBehaviour
{
	private SphereCollider m_collider;
    // Start is called before the first frame update
    void Start()
    {
		for (int i=0 ; i<4 ; i++) {
			// AddComponent creates the object and links it to the game object:
			m_collider = this.gameObject.AddComponent<SphereCollider>();
			int j = i%2;
			m_collider.center = new Vector3( -0.05f+0.1f*Random.value, 0, 0.05f+0.1f*Random.value ); // the center must be in local coordinates
			m_collider.radius = 0.1f;
		}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
