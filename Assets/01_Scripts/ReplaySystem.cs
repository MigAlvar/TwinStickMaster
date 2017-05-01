using UnityEngine;
using System.Collections;

public class ReplaySystem : MonoBehaviour {

	private const int bufferFrames =100;
	private myKeyframe[] keyFrames = new myKeyframe[bufferFrames];
	private Rigidbody itsRigidbody;

	// Use this for initialization
	void Start () {
		itsRigidbody= GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Record ();

	}
	void PlayBack(){
		itsRigidbody.isKinematic = true;
		int frame = Time.frameCount % bufferFrames;
		transform.position = keyFrames[frame].position;
		transform.rotation = keyFrames[frame].rotation;
	}

	void Record ()
	{
		itsRigidbody.isKinematic = false;
		int frame = Time.frameCount % bufferFrames;
		float tm = Time.time;
		keyFrames [frame] = new myKeyframe (tm, transform.position, transform.rotation);
	}
}
//<sumaary>
//	A structure for storing time, position and rotation
//</summary>
public struct myKeyframe{

	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;

	public myKeyframe (float t, Vector3 p, Quaternion r)
	{
		frameTime = t;
		position = p;
		rotation = r;
	}
		
	}