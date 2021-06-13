using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;

    public void Summon()
    {
        Instantiate(_enemy, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }
}
