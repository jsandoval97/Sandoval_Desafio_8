using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField]
    protected ZombieData zombieData;


    void Start()
    {

    }

    void Update()
    {
        Move();
        Attack();
    }

    protected virtual void Move()
    {
        transform.Translate(Vector3.forward * zombieData.speed * Time.deltaTime);
    }

    public void Attack()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, zombieData.RangeAttack)){
            if(hit.transform.CompareTag("Player")){
                Debug.Log("Atacar al jugador");
            }
        }
    }

    public void DrawRaycast()
    {
        Gizmos.color = Color.blue;
        Vector3 directionRay = transform.TransformDirection(Vector3.forward) * zombieData.RangeAttack;
        Gizmos.DrawRay(transform.position + Vector3.up, directionRay);
    }

    private void OnDrawGizmos()
    {
        DrawRaycast();
    }
}