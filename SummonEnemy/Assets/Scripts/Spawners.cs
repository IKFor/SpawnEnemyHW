using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    [SerializeField] private float _spawnTime = 2;

    private Spawner[] _spawners;
    private int _currentSpawner = 0;
    private float _timeAfterLastSpawn = 0;

    private void Awake()
    {
        _spawners = GetComponentsInChildren<Spawner>();
    }

    private void Update()
    {
        _timeAfterLastSpawn += Time.deltaTime;
        if (_timeAfterLastSpawn >= _spawnTime)
        {
            _timeAfterLastSpawn = 0;
            _currentSpawner++;

            if (_currentSpawner >= _spawners.Length)
                _currentSpawner = 0;

            _spawners[_currentSpawner].Summon();
        }
    }
}
