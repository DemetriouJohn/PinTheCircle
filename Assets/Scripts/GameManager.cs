using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private Button _shootButton;

    [SerializeField]
    private GameObject _needle;
    private GameObject[] _needles;
    private float _needleDistance = 0.5f;
    private int _needleIndex = 0;

    [SerializeField]
    private int _totalNeedles;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        _shootButton = GameObject.FindWithTag("ShootButton").GetComponent<Button>();
    }

    public void ShootTheNeedle()
    {
        if (_needleIndex == _totalNeedles)
        {
            _shootButton.onClick.RemoveAllListeners();
            return;
        }

        _needles[_needleIndex].GetComponent<NeedleMovement>().FireTheNeedle();
        _needleIndex++;
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
