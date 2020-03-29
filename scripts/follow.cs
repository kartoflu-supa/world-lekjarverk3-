using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    Transform player;
    Vector3 offset;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        offset.y = 20;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
