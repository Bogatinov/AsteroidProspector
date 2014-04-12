using UnityEngine;
using System.Collections;

public class AsteroidContoller : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
				transform.Rotate (Vector3.forward * -90);
		}
	
		// Update is called once per frame
		void Update ()
		{
				//rigidbody2D.AddTorque (5);
				transform.Rotate (Vector3.forward * -90 * Time.deltaTime);
				
		}
}
