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

    }

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }
}
