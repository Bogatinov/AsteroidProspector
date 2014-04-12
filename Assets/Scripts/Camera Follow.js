#pragma strict

var cameraTarget : GameObject; // Inspector> Assign the Camera Target NON è il target della camera ma la posizione che vuole raggiungere la camera
 
var smoothTime : float = 0.5;
var cameraFollowX : boolean = true;        // Inspector> if is checked -> The Camera will follow X position of cameraTarget
var cameraFollowY : boolean = true;        // Inspector> if is checked -> The Camera will follow Y position of cameraTarget
var cameraFollowHeight : boolean = false;  // if true the Camera Y Position = cameraHeight
var cameraHeight : float = 10;            // cameraHeight
var velocity : Vector2;
private var thisTransform : Transform;    
 
function Start ()
{
  thisTransform = transform;
}
 
function Update () 
{
 
if (cameraFollowX) // if cameraFollowX = true = Inspector is checked
{
  thisTransform.position.x = Mathf.SmoothDamp (thisTransform.position.x, cameraTarget.transform.position.x, velocity.x, smoothTime);
}
 
if (cameraFollowY) // if cameraFollowY = true = Inspector is checked
{
  thisTransform.position.y = Mathf.SmoothDamp (thisTransform.position.y, cameraTarget.transform.position.y, velocity.y, smoothTime);
}
 
if (!cameraFollowY && cameraFollowHeight)     // if cameraFollowY = false = Inspector is unchecked AND cameraFollowHeight = true = Inspector is checked
{
  camera.transform.position.y = cameraHeight; // The Camera Y position = cameraHeight
}
 
}