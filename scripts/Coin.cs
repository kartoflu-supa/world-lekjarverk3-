using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    public float rotatSpeed;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        transform.Rotate(rotatSpeed*Time.deltaTime, 0, 0);
    }
}
 