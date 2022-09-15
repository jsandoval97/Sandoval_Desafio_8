using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieJumper : Zombie
{
    [SerializeField]
    [Range(1f, 10f)]
    private float jumpForce = 2f;

    private Rigidbody rbEnemy = null;

    private void Start()
    {
        rbEnemy = GetComponent<Rigidbody>();
        InvokeRepeating("JumpZombie", 0f, 2f);
    }

    private void JumpZombie()
    {
        Debug.Log("Saltando");
        rbEnemy.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}