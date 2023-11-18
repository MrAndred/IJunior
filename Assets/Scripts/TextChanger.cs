using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _endText;
    [SerializeField] private float _duration;

    private Sequence _sequence;
    private int _loops = -1;

    private void Start()
    {
        _sequence = DOTween.Sequence();

        CreateSequence();
        _sequence.SetLoops(_loops, LoopType.Restart).SetEase(Ease.Linear);
        _sequence.Play();
    }

    private void CreateSequence()
    {
        int animationCount = 3;
        float animationDurationPerSequenceItem = _duration / animationCount;

        ChangeTextSequence(animationDurationPerSequenceItem);
        AddTextSequence(animationDurationPerSequenceItem);
        ChangeTextByOverdrive(animationDurationPerSequenceItem);
    }

    private void ChangeTextSequence(float duration)
    {
        _sequence.Append(_text.DOText(_endText, duration));
    }

    private void AddTextSequence(float duration)
    {
        _sequence.Append(_text.DOText(_endText, duration).SetRelative());
    }

    private void ChangeTextByOverdrive(float duration)
    {
        _sequence.Append(_text.DOText(_endText, duration, true, ScrambleMode.Numerals));
    }
}
