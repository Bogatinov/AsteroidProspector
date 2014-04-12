using UnityEngine;
using System.Collections;

public class SpaceShipController : MonoBehaviour
{

		private Vector3 moveDirection;
		public float moveSpeed = 2;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				// 1
				Vector3 currentPosition = transform.position;
				// 2
				if (Input.GetButton ("Fire1")) {
						// 3
						Vector3 moveToward = Camera.main.ScreenToWorldPoint (Input.mousePosition);
						// 4
						moveDirection = moveToward - currentPosition;
						moveDirection.z = 0; 
						moveDirection.Normalize ();
				}
		}
}
