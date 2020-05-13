using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private Button _shootButton;

    [SerializeField]
    private GameObject _needle;
    private GameObject[] _needles;
    private float _needleDistance = 1.5f;
    private int _needleIndex;

    [SerializeField]
    private int _totalNeedles;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void GetButton()
    {
        _shootButton = GameObject.FindWithTag("ShootButton").GetComponent<Button>();
    }

    public void ShootTheNeedle()
    {

    }

    // Start is called before the first frame update
    private void Start()
    {
        CreateNeedles();
    }

    private void CreateNeedles()
    {
        _needles = new GameObject[_totalNeedles];
        Vector3 temp = transform.position;
        for (int i = 0; i < _needles.Length; i++)
        {
            _needles[i] = Instantiate(_needle, temp, Quaternion.identity);
            temp.y -= _needleDistance;
        }
    }

    public void InstantiateNeedle()
    {
        Instantiate(_needle, transform.position, Quaternion.identity);
    }
}
