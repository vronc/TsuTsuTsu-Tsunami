using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heat : MonoBehaviour
{
	public float celsius {get; set;}

	float MAX_CELSIUS = 90.0f;
	Light c_light;
	Color c;
    // Start is called before the first frame update
    void Start()
    {
		celsius = 20.0f;
		c_light = GetComponentInChildren<Light>();
		c = new Color();
		c.r= 1f;
		c.g = 1f-(celsius/MAX_CELSIUS);
		c.b= 0f;
		c.a=1f;
		c_light.color = c;
    }
		
    // Update is called once per frame
    void Update()
    {
		c.g= 1f-(celsius/MAX_CELSIUS);
		c_light.color = c;
		c_light.intensity = 0.5f+celsius/MAX_CELSIUS;
    }
}
