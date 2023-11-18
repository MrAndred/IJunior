using UnityEngine;
using DG.Tweening;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Color _endColor;
    [SerializeField] private float _duration;

    private Tween _tween;
    private int _loops = -1;

    private void Start()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        _tween =_renderer.material.DOColor(_endColor, _duration).SetLoops(_loops, LoopType.Yoyo);
        _tween.SetEase(Ease.Flash);
    }
}
