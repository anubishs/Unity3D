using UnityEngine;
public class WaypointControl : MonoBehaviour {
	static Color     linkColor     = Color.red;
	public Color     waypointColor = Color.cyan;
	public float     radius        = 0.1F;
	public Transform next;

	public void OnDrawGizmos() {
		Gizmos.color = waypointColor;
		Gizmos.DrawSphere(transform.position, radius);
		if (next != null) {
			Gizmos.color = linkColor;
			Gizmos.DrawLine(transform.position, next.position);
		}
	}
}