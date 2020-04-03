using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotatSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotatSpeed * Time.deltaTime, 0);
    }
}//þetta script snýr object eftir hraðan sem ert tekkin fram
