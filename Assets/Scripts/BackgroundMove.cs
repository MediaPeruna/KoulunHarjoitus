using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackgroundMove : MonoBehaviour
{
	private float length, startPosition;
	public GameObject cam1;
	public float parallaxEffect;
	
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position.x;
		length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float temp = (cam1.transform.position.x * (1 - parallaxEffect));
		float dist = (cam1.transform.position.x * parallaxEffect);
		transform.position = new Vector3(startPosition + dist, transform.position.y, transform.position.z);
		
		if (temp > startPosition + length)
		{
			startPosition += length;
		}
		else if (temp < startPosition - length)
		{
			startPosition -= length;
		}
    }
}