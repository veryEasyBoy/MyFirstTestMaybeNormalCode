using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class GroundCheck : Player
{
    protected bool isGrounded;
    private Ray ray;
    [SerializeField] private float distanceRay;
    [SerializeField] private LayerMask layerMask;
   
    protected void RaycastPlayer()
    {
        ray = new Ray(transform.position, -transform.up);
        isGrounded = (Physics.Raycast(ray, distanceRay, layerMask));

    }
}
