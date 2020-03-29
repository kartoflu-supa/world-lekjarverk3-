using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteractions : MonoBehaviour
{
    public AudioSource ouch;
    public AudioClip oof;
    public AudioClip heel;
    public Vector3 spun;

    bool hit = false;

    float starttime = 100f;
    int helth = 10;
    float time;
    Text hitpont;

    private void Start()
    {
        ouch = GameObject.FindWithTag("Player").GetComponent<AudioSource>();
        hitpont = FindObjectOfType<Text>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 9 && hit == false)
        {
            ouch.clip = oof;
            ouch.Play();
            hit = true;
            helth -= 1;
            time = starttime;
        }
        if (collision.gameObject.CompareTag("coin"))
        {
            ouch.clip = heel;
            ouch.Play();
            helth = 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        hitpont.text = "HP: " + helth.ToString();
        if (hit == true)
        {
            if (time == 0f)
            {
                hit = false;
            }
            else
            {
                time -= 1f;
            }
        }
        if (helth == 0)
        {
            transform.position = spun;
            helth = 10;
        }
    }
}
