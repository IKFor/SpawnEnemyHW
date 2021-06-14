using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _spawnDelay = 2;

    private SpawnPoint[] _spawnPoints;
    private int _currentSpawnPoints = 0;
    private float _timeAfterLastSpawn = 0;

    private void Awake()
    {
        _spawnPoints = GetComponentsInChildren<SpawnPoint>();
    }

    private void Update()
    {
        _timeAfterLastSpawn += Time.deltaTime;
        if (_timeAfterLastSpawn >= _spawnDelay)
        {
            _timeAfterLastSpawn = 0;
            _currentSpawnPoints++;

            if (_currentSpawnPoints >= _spawnPoints.Length)
                _currentSpawnPoints = 0;

            _spawnPoints[_currentSpawnPoints].Spawn();
        }
    }
}
