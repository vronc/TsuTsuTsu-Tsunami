using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBlobObjects : MonoBehaviour
{
	private SphereCollider m_collider;
	private Rigidbody rb;
	private BlobMovement movement;
	private int nrOfBlobs = 1;
    // Start is called before the first frame update
    void Start()
    {
		for (int i=0 ; i<nrOfBlobs ; i++) {

			GameObject child = new GameObject();
			child.transform.parent = this.gameObject.transform;
			child.transform.position = new Vector3(0.75f*i, 0.0f, 0.5f*i);
			m_collider = child.gameObject.AddComponent<SphereCollider>();
			rb = child.gameObject.AddComponent<Rigidbody>();
			rb.useGravity = false;
			movement = child.gameObject.AddComponent<BlobMovement>();

			rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
			rb.mass = 5.0f;
			int j = i%2;
			float floatation = Mathf.Pow(( (3*rb.mass) / (4*Mathf.PI) ),(1/3));
			m_collider.radius = floatation;
		}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
