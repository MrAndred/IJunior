using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _endScale;
    [SerializeField] private float _duration = 1f;

    private Tween _tween;
    private int _loops = -1;

    private void Start()
    {
        Scale();
    }

    private void Scale()
    {
        _tween = transform.DOScale(_endScale, _duration).SetLoops(_loops, LoopType.Yoyo);
        _tween.SetEase(Ease.InCubic);
    }
}
