using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    
    private void Start()
    {
        float distance = Vector3.Distance(transform.position, Vector3.zero);
        float time = distance / _moveSpeed;
        transform.DOMove(Vector3.zero, time).SetEase(Ease.Linear).OnComplete(() => Destroy(gameObject));
    }
}
