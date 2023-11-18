using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private float _duration = 1f;

    private int _loops = -1;
    private Tween _tween;

    private void Start()
    {
        Move();
    }

    private void Move()
    {
        _tween = transform.DOMove(_endPosition, _duration).SetLoops(_loops, LoopType.Yoyo);
        _tween.SetEase(Ease.Linear);
    }
}
