using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gamemanager : MonoBehaviour
{
    public GameObject player;
    public Material[] skyboxes;
    float timestart = 120f;
    float time;
    int sky = 8;

    private void Start()
    {
        RenderSettings.skybox = skyboxes[8];
        time = timestart;
    }
    private void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (time > 0)
        {
            time -= 1;
        }
        else
        {
            sky += 1;
            if (sky == 0)
            {
                RenderSettings.skybox = skyboxes[0];
                time = timestart;
            }
            else if (sky == 1)
            {
                RenderSettings.skybox = skyboxes[1];
                time = timestart;
            }
            else if (sky == 2)
            {
                RenderSettings.skybox = skyboxes[2];
                time = timestart;
            }
            else if (sky == 3)
            {
                RenderSettings.skybox = skyboxes[3];
                time = timestart;
            }
            else if (sky == 4)
            {
                RenderSettings.skybox = skyboxes[4];
                time = timestart;
            }
            else if (sky == 5)
            {
                RenderSettings.skybox = skyboxes[5];
                time = timestart;
            }
            else if (sky == 6)
            {
                RenderSettings.skybox = skyboxes[6];
                time = timestart;
            }
            else if (sky == 7)
            {
                RenderSettings.skybox = skyboxes[7];
                time = timestart;
            }
            else if (sky == 8)
            {
                RenderSettings.skybox = skyboxes[8];
                time = timestart;
            }
            else if (sky == 9)
            {
                RenderSettings.skybox = skyboxes[9];
                time = timestart;
            }
            else if (sky == 10)
            {
                RenderSettings.skybox = skyboxes[10];
                time = timestart;
            }
            else if (sky == 11)
            {
                RenderSettings.skybox = skyboxes[11];
                time = timestart;
            }
            else if (sky == 12)
            {
                RenderSettings.skybox = skyboxes[12];
                time = timestart;
            }
            else if (sky == 13)
            {
                RenderSettings.skybox = skyboxes[13];
                time = timestart;
            }
            else if (sky == 14)
            {
                RenderSettings.skybox = skyboxes[14];
                time = timestart;
            }
            else if (sky == 15)
            {
                RenderSettings.skybox = skyboxes[15];
                time = timestart * 12;
            }
            else
            {
                sky = 0;
                RenderSettings.skybox = skyboxes[0];
            }
        }
    }
}
