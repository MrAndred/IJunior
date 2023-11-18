using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _endAngle;
    [SerializeField] private float _duration = 1f;

    private Tween _tween;
    private int _loops = -1;

    private void Start()
    {
        Rotate();
    }

    private void Rotate()
    {
        _tween = transform.DORotate(_endAngle, _duration, RotateMode.FastBeyond360).SetLoops(_loops, LoopType.Yoyo);
        _tween.SetEase(Ease.Linear);
    }
}
