using UnityEngine;
public class spawnenemy : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    private float _timer = 0;
    private void Update()
    {
        _timer += Time.deltaTime;
        if(_timer >= 10)
        {
            GameObject obj = Instantiate(_prefab, transform.position, Quaternion.identity);
            _timer = 0;
        }
    }
}