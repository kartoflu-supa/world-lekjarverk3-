using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public GameObject player;//leikmaðurinn
    public Material[] skyboxes;//listi af himnum
    readonly float timestart = 120f;//tíminn milli himan breytingar
    float time;//núverandi tími milli breytingar
    int sky = 8;//himininn sem núna er í gangi
    public Vector3 spun;//staðsetninginn sem player fer á eftir dauða
    public Vector3 end;//staðsetning hjá enda heimsins

    private void Start()
    {
        RenderSettings.skybox = skyboxes[8];//breytir himninum í himmin númmer 8
        time = timestart;//byrjar klukkuna
    }

    public int Ded()//fall sem endurlífgar leikmanninn
    {
        player.SetActive(false);
        player.transform.position = spun;
        int helth = 10;
        player.SetActive(true);
        return helth;
    }

    public void Boundry()//fall sem sendir leikmann til enda heimsins
    {
        player.SetActive(false);
        player.transform.position = end;
        player.SetActive(true);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (time > 0)//ef tímminn er meira enn núll
        {
            time -= 1;//lækka þá tímann
        }
        if (time <= 0)
        {
            sky += 1;
            if (sky == 1)
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
            else// annars byrja upp á nýtt
            {
                sky = 0;
                RenderSettings.skybox = skyboxes[0];
                time = timestart;
            }
        }
    }
}
