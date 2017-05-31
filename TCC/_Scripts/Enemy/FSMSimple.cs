using UnityEngine;
public class FSMSimple : MonoBehaviour {

	#region FSM States
	public enum      FSMStates { Waypoints, Chasing, Shooting, Firing };
	public FSMStates state = FSMStates.Waypoints;
	#endregion

	#region Generic Variable
	public  GameObject target;
	public  float      speed;
	public  float      rotSpeed;
	private float      timer;
	private Vector3    dir;
	private Rigidbody  rb;
	#endregion

	#region Wapypoints
	public  Transform[] waypoints;
	public  float       distanceToChangeWaypoint;
	private int         currentWaypoint;
	#endregion


	#region Unity Functions
	public void Start() {
		currentWaypoint = 0;
		timer           = 0;
		rb              = GetComponent<Rigidbody>();



	}


	public void FixedUpdate() {
		dir = target.transform.position - transform.position;

		switch (state) {
		case FSMStates.Waypoints: WaypointState(); break;

		default: print("BUG: state should never be on default clause"); break;
		}
	}
	#endregion

	#region Wapypoints State
	private void WaypointState() {
		

		// Find the direction to the current waypoint,
		//   rotate and move towards it
		Vector3 wpDir         = waypoints[currentWaypoint].position - transform.position;
		transform.rotation    = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(wpDir), Time.deltaTime * rotSpeed);
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
		if (wpDir.magnitude <= distanceToChangeWaypoint) {
			currentWaypoint++;
			if (currentWaypoint >= waypoints.Length)
				currentWaypoint = 0;

		} else
			rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
	}
	#endregion






}