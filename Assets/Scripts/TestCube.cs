using UnityEngine;

public class TestCube : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;

    [SerializeField] private float _moveSpeed = 10f;
    private void Start()
    {
        _cube = gameObject;
    }

    private void Update()
    {
        if (_cube == null)
            return;

        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Vector2 dir = new Vector2(h, v).normalized;

        transform.Translate(dir * Time.deltaTime * _moveSpeed);
    }
}
