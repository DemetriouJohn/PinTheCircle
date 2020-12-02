using UnityEngine;

public class NeedleMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject _needleBody;
    private bool _canShootNeedle;
    private bool _touchedTheCircle;
    private float speed = 50f;
    private Rigidbody2D _myBody;

    private void Awake()
    {
        Initialize();
    }

    private void FixedUpdate()
    {
        _myBody.velocity = _canShootNeedle ? new Vector2(0, speed) : new Vector2(0, 0);
    }

    private void Initialize()
    {
        _needleBody.SetActive(false);
        _myBody = GetComponent<Rigidbody2D>();
    }

    public void FireTheNeedle()
    {
        _needleBody.SetActive(true);
        _myBody.isKinematic = false;
        _canShootNeedle = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_touchedTheCircle)
        {
            return;
        }

        if (other.CompareTag("Circle"))
        {
            _canShootNeedle = false;
            _touchedTheCircle = true;
            _myBody.isKinematic = true;
            transform.SetParent(other.transform);
        }
    }
}
