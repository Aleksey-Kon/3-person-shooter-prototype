using UnityEngine;
public class enemy : MonoBehaviour
{
    [SerializeField] private GameObject _base;
    public static float Hp;
    private void Start()
    {
        Hp = 100;
        _base = GameObject.FindGameObjectWithTag("base");
    }
    private void Update()
    {
        if (Hp <= 0)
        {
            Destroy(gameObject);
            Hp = 100;
        }
        transform.LookAt(_base.transform.position);
        //transform.position = _base.transform.position * Time.deltaTime *0.1f;
        transform.position += transform.forward * Time.deltaTime * 12f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "base") {
            baseHp.hp -= 10;
        }
    }
}