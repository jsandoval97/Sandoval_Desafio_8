using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieRioter : Zombie
{
    [SerializeField] Transform playerTransform;

    void Start()
    {

    }

    void Update()
    {

    }

    protected override void Move()
    {
        LookPlayer();
        transform.RotateAround(playerTransform.position, Vector3.up, 2f * Time.deltaTime);
    }

    private void LookPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(playerTransform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 1.5f * Time.deltaTime);
    }
}