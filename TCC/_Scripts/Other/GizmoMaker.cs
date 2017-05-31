using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoMaker : MonoBehaviour
{
    public Color gizmoColor = Color.yellow;
    public float radius = 0.2f;

    public void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawSphere(transform.position, radius);
    }

}
