using UnityEngine;

public class Scalation : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 1f;

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
