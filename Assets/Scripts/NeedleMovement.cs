using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject _needleBody;
    private bool _canShootNeedle;
    private bool _touchedTheCircle;
    private float speed = 70f;
    private Rigidbody2D _myBody;

    private void Awake()
    {
        Initialize();
    }

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (_canShootNeedle)
        {
            _myBody.velocity = new Vector2(0, speed);
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
}
