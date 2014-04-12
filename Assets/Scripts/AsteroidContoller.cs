using UnityEngine;
using System.Collections;

public class AsteroidContoller : MonoBehaviour
{
		private float Speed;

		void Start ()
		{
				gameObject.renderer.enabled = false;
		}
	
		void Update ()
		{
				transform.Rotate (Vector3.forward * -90 * Time.deltaTime);
				if (transform.localScale.x <= 1) {
						Speed = 2.5f;
				} else if (transform.localScale.x <= 2 && transform.localScale.x > 1) {
						Speed = 1.5f;
				} else {
						Speed = 0.5f;
				}

				transform.position -= Vector3.right * Speed * Time.deltaTime;
		}
}
