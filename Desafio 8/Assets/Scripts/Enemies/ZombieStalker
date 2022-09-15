using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieStalker : Zombie
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
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 1f)
        {
           transform.position += direction.normalized * zombieData.speed * Time.deltaTime;
        }
    }

    private void LookPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(playerTransform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 1.5f * Time.deltaTime);
    }
}