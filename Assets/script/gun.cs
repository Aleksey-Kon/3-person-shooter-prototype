using UnityEngine;
public class gun : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject obj;
    private float _timer;
    private void Start()
    {
        _timer = Time.deltaTime;
    }
    void Shooting()
    {
        _timer = 0;
        obj = Instantiate(_prefab, transform.position, Quaternion.identity);
        obj.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -250), ForceMode.Impulse);
    }
    private void Update()
    {
        _timer += Time.deltaTime;
        if (Input.GetMouseButton(0) && _timer >= 0.1f)
        {
            Shooting();
        }
    }
}
