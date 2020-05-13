using System.Collections;
using System.Collections.Generic;
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

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (_canShootNeedle)
        {
            _myBody.velocity = new Vector2(0, speed);
        }
        else
        {
            _myBody.velocity = new Vector2(0, 0);
        }
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

        if (other.tag == "Circle")
        {
            _canShootNeedle = false;
            _touchedTheCircle = true;
            _myBody.isKinematic = true;
            transform.SetParent(other.transform);
        }
    }
}
