using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUps : MonoBehaviour
{
    //This is the parent class for the pick ups

    [SerializeField] private float rotationSpeed = 90f;
    [SerializeField] private float lifeSpan = 20f;

    void Awake()
    {
        Destroy(gameObject, lifeSpan);
    }

    void Start()
    {

    }

    void Update()
    {

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        if (player)
        {
            OnPickUp(player);
        }
    }

    protected virtual void OnPickUp(Player player)
    {
        Destroy(gameObject);
    }
}
