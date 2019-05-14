using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBlobColliders : MonoBehaviour
{
	private SphereCollider m_Collider;
    // Start is called before the first frame update
    void Start()
    {
		// AddComponent creates the object and links it to the game object:
		m_Collider = this.gameObject.AddComponent<SphereCollider>();
		m_Collider.center = Vector3.zero; // the center must be in local coordinates
		m_Collider.radius = 0.1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
