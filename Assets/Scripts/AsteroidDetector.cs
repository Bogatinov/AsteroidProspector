using UnityEngine;
using System.Collections;

public class AsteroidDetector : MonoBehaviour
{
		void OnTriggerEnter2D (Collider2D other)
		{
				other.gameObject.renderer.enabled = true;
		}

		void OnTriggerExit2D (Collider2D other)
		{
				other.gameObject.renderer.enabled = false;
		}
}
