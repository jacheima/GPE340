using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    private Animator animator;

    private Transform target;
    private Camera main;

    [SerializeField] private float forwardSpeed = 1000f;
    [SerializeField] private float turnSpeed = 180f;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
        main = GameObject.Find("Main Camera").GetComponent<Camera>();
        target = GetComponentInChildren<Transform>();
    }
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        animator.SetFloat("Speed", vertical);

        RotateToMousePosition();

        if (vertical != 0)
        {
            characterController.SimpleMove(transform.forward * forwardSpeed * Time.deltaTime);
        }


    }

    private void RotateToMousePosition()
    {
        Plane groundPlane = new Plane(Vector3.up, target.position);
        
        //Find the distance down the ray that the plane intersection is at
        float distance;
        Ray ray = main.ScreenPointToRay(Input.mousePosition);

        if (groundPlane.Raycast(ray, out distance))
        {
            //Find world point where intersection is at
            Vector3 intersectionPoint = ray.GetPoint(distance);

            //Rotate towards the intersection point
            target.LookAt(intersectionPoint);
        }

        


    }
}
