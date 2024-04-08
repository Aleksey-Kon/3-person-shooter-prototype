using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdestroy : MonoBehaviour
{
    private float _timer = 0f;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            enemy.Hp -= 10;
        }
    }
    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= 4f)
        {
            Destroy(gameObject);
        }
    }
}
