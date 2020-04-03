using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteractions : MonoBehaviour
{
    AudioSource ouch;  //audiosource hlutur sem spilar hljóðinn
    public AudioClip oof;  //hljóðið fyrir að vera meiddur
    public AudioClip heel;  //hljóðið fyrir að laga sárinn

    bool hit = false;  //flag fyrir tímann á millin því að ver meiddur

    readonly float starttime = 100f;  //Tíminn milli hvert högg
    int helth = 10;  //lífið sem þú byrjar með
    float time;  //núvernadi tími milli högg
    Text hitpont;  //hlutur sem sýnir hvað mikið líf þú ert með

    private void Start()
    {
        //finnur audiosource tengd við leikmaninn og UI textinn
        ouch = GameObject.FindWithTag("Player").GetComponent<AudioSource>();
        hitpont = FindObjectOfType<Text>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 11 || collision.gameObject.CompareTag("coin"))  //ef hlutur með taginu eða á layerinu fyrir pickups er snertur spilar það hljóðið sem lagar sárinn og breyttir lífinu í 10
        {
            ouch.clip = heel;
            ouch.Play();
            helth = 10;
        }
        if (collision.gameObject.layer == 9 && hit == false)  //ef hluturinn sem er snertur er á layerinu fyrir óvini og tími milli högg er búinn ertu lammin og spilar það hljóðið þegar þú ert laminn og telur svo aftur niður
        {
            ouch.clip = oof;
            ouch.Play();
            hit = true;
            helth -= 1;
            time = starttime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            helth = FindObjectOfType<gamemanager>().Ded();
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            FindObjectOfType<gamemanager>().Boundry();
        }
        hitpont.text = "HP: " + helth.ToString();  //byrtir hvað mikið líf þú ert með
        if (hit == true)//ef þú ert búinn að vera lamminm
        {
            if (time == 0f)//og tímminn er búinn geturu verið lamminn
            {
                hit = false;
            }
            else//annars lækka tímann um 1f
            {
                time -= 1f;
            }
        }
        if (helth == 0)//ef þú dóst ertu lífgaður við hjá tré lífsins(respawn)
        {
            helth = FindObjectOfType<gamemanager>().Ded();
        }
    }
}
