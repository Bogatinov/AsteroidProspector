	using UnityEngine;
using System.Collections;

public class SpaceShipController : MonoBehaviour
{

		private Vector3 moveDirection;
		public float moveSpeed = 0;
		public float turnSpeed = 0;
		private Vector3 moveToward;

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
						moveToward = Camera.main.ScreenToWorldPoint (Input.mousePosition);
						moveToward.z = 0;
						CircleCollider2D circle = transform.GetComponent<CircleCollider2D> ();
						if ((moveToward - currentPosition).sqrMagnitude > circle.radius / 15) {		
								moveSpeed = 5;
								turnSpeed = 5;
								// 4
								currentPosition.z = 0;
								moveDirection = moveToward - currentPosition;
								moveDirection.z = 0; 
								moveDirection.Normalize ();
							
								
								float targetAngle = Mathf.Atan2 (moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
								transform.rotation = 
			Quaternion.Slerp (transform.rotation, 
			                  Quaternion.Euler (0, 0, targetAngle), 
			                  turnSpeed * Time.deltaTime);
								collider2D.rigidbody2D.AddForce (moveDirection * moveSpeed);
						}
				}
			
		}
}
