using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private EnemyMovement _enemyPrefab;
    [SerializeField] private float _timeBetweenSpawns;
    
    private Queue<Transform> _queue;

    private void Awake()
    {
        _queue = new Queue<Transform>(_spawnPoints);
    }

    private void Start()
    {
        StartCoroutine(StartSpawning());
    }

    private IEnumerator StartSpawning()
    {
        var waitTime = new WaitForSeconds(_timeBetweenSpawns);
        
        while (_queue.Count > 0)
        {
            var spawnPoint = _queue.Dequeue();
            Instantiate(_enemyPrefab, spawnPoint.position, Quaternion.identity);
            _queue.Enqueue(spawnPoint);
            yield return waitTime;
        }
    }
}
