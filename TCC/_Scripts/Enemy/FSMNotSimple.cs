using UnityEngine;
public class FSMNotSimple: MonoBehaviour {

	#region FSM States
	public enum      FSMStates { Waypoints, Chasing};
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

	#region Waypoints
	public  Transform[] waypoints;
	public  float       distanceToChangeWaypoint;
	private int         currentWaypoint;
	#endregion

	#region Chasing
	public float distanceToStartChasing;
	public float distanceToStopChasing;
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
		case FSMStates.Chasing:   ChaseState();    break;

		default: print("BUG: state should never be on default clause"); break;
		}
	}
	#endregion

	#region Wayppoints State
	private void WaypointState() {
		// Check if target is in range to chase
		if (dir.magnitude <= distanceToStartChasing) {
			state = FSMStates.Chasing;
			return;
		}

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

	#region Chasing State
	private void ChaseState() {
        // Check if target is close enough to shoot or fire
        //   or if target is too far way, then return to Waypoints
        if (dir.magnitude > distanceToStopChasing)
        {
            state = FSMStates.Waypoints;
            return;
        }
		transform.rotation    = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotSpeed);
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
		rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
	}
	#endregion
}