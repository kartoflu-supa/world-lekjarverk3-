using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    GameObject self;
    private void Start()
    {
        self = gameObject;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 8)  //eyðir hlutinn sem scriptan tilheyrir ef leikmaður snertir það
        {
            GameObject.Destroy(self);
        }
    }
    public float rotatSpeed;
    private void Update()
    {
        transform.Rotate(rotatSpeed*Time.deltaTime, 0, 0); // snýr hlutinn sem scriptann tilheyrir
    }
}
 