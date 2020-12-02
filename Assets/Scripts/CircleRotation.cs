using UnityEngine;

public class CircleRotation : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed = 50f;
    private bool _canRotate = true;
    private float _angle;

    private void Awake()
    {

    }

    private void RotateCircle()
    {
        _angle = transform.rotation.eulerAngles.z;
        _angle += _rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, _angle));
    }

    private void Update()
    {
        if (_canRotate)
        {
            RotateCircle();
        }
    }
}
