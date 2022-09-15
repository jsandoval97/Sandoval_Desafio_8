using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Zombie Data", menuName = "Crear Zombie Data")]
public class ZombieData : ScriptableObject
{
    [Header("Configuración de movimiento")]

    [Tooltip("La velocidad de movimiento va de 1 a 10")]
    [SerializeField]
    [Range(1f, 10f)]
    public float speed = 2f;


    [Header("CONFIGUARACION DE ATAQUE")]
    
    [SerializeField]
    [Range(1f, 10f)]
    private float rangeAttack = 2f;
    public float RangeAttack { get => rangeAttack; }
}