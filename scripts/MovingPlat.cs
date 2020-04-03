using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{
    public bool direction;//áfram eða afturábak
    public int distance;//lengdinn frá byrjunina
    public bool xorz;//x eða z
    public int stop;//hvar stoppar
    public int duration;//tími milli hreyfinga
    int cooldown;//núverandi tími milli hreyfinga

    // Update is called once per frame
    void FixedUpdate()
    {
        if (cooldown == 0)//ef núverandi tími er núll þá
        {
            if (direction == true)//ef áfram þá
            {
                distance += 1;//hækkaðu lengdinn sem frá byrjun
                if (xorz == true)//ef x þá
                {
                    Vector3 next = transform.position;//næsta staðsetning
                    next.x += 1;//hækkuð um 1 í x ásnum
                    transform.SetPositionAndRotation(next, transform.rotation);//breyttu yfir á næstu staðsetningu
                }
                if (xorz == false)//ef z þá
                {
                    Vector3 next = transform.position;//næsta staðsetning
                    next.z += 1;//hækkuð um 1 í z ásnum
                    transform.SetPositionAndRotation(next, transform.rotation);//breyttu yfir á næstu staðsetningu
                }
            }
            else if (direction == false)//ef afturábak þá
            {
                distance -= 1;//lækkaðu lengd frá byrjunar reitt
                if (xorz == true)//ef x þá
                {
                    Vector3 next = transform.position;//næsta staðsetning
                    next.x -= 1;//lækka x ásinn
                    transform.SetPositionAndRotation(next, transform.rotation);//breytta yfir á næstu staðsetningu
                }
                if (xorz == false)//ef z þá
                {
                    Vector3 next = transform.position;//næsta staðsetning
                    next.z -= 1;//lækka z ásinn
                    transform.SetPositionAndRotation(next, transform.rotation);//breytta yfir á næstu staðsetningu
                }
            }
            if (direction)//ef áfram þá
            {
                if (distance >= stop)//ef lengd er meiri eða jafnt og stop þá
                {
                    direction = false;//snúa við
                }
            }
            else//annars
            {
                if (distance <= 0)//ef lengd er meira eða jafnt og 0 þá
                {
                    direction = true;//snúa við
                }
            }
            cooldown = duration;//byrja klukkuna
        }
        else//annars
        {
            cooldown -= 1;//lækka núverandi tími
        }
    }
}
