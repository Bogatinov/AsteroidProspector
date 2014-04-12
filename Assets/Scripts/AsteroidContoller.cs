using UnityEngine;
using System.Collections;

public class AsteroidContoller : MonoBehaviour
{
		private float Speed;

		void Start ()
		{
		}
	
		void Update ()
		{
				transform.Rotate (Vector3.forward * -90 * Time.deltaTime);
				if (transform.localScale.x <= 1) {
						Speed = 7;
				} else if (transform.localScale.x <= 2 && transform.localScale.x > 1) {
						Speed = 4;
				} else {
						Speed = 2;
				}

				transform.position -= Vector3.right * Speed * Time.deltaTime;
		}
}
