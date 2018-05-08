using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovement : MonoBehaviour {

	public float RotateSpeed = 5f;
    public float Radius = 0.1f;
 
    private Vector2 _centre;
    private float _angle;
 
    private void Start()
    {
        _centre = transform.position;
    }
 
    private void Update()
    {
 
        _angle += RotateSpeed * Time.deltaTime;


		float x = Mathf.Sin(_angle);
		float y = Mathf.Cos(_angle);
 
        Vector2 offset = new Vector2(x, y) * Radius;
        transform.position = _centre + offset;
    }
}
