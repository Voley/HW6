using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    void Start()
    {
        float distance = Vector3.Distance(transform.position, Vector3.zero);
        float time = distance / 1.5f;
        transform.DOMove(Vector3.zero, time).SetEase(Ease.Linear).OnComplete(() => Destroy(gameObject));
    }
}