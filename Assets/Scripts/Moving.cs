using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobing : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _rotationSpeed = 1f;
    [SerializeField] private float _scaleSpeed = 1f;

    [SerializeField] private GameObject rotationCube;
    [SerializeField] private GameObject _mixedCube;
    [SerializeField] private GameObject _scalingCapsule;
    [SerializeField] private GameObject _movingSphere;

    private void Update()
    {
        MoveSphere();
        RotateCube();
        ScaleCapsule();
        MixCube();
    }

    private void MoveSphere()
    {
        _movingSphere.transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    private void RotateCube()
    {
        rotationCube.transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }

    private void ScaleCapsule()
    {
        _scalingCapsule.transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }

    private void MixCube()
    {
        _mixedCube.transform.Translate(_mixedCube.transform.forward * _speed * Time.deltaTime);
        _mixedCube.transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
        _mixedCube.transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
