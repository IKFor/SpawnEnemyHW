using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _enemyTemplate;

    public void Spawn()
    {
        Instantiate(_enemyTemplate, transform.position, Quaternion.identity);
    }
}
