using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime);
    }
}
