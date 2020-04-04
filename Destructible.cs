// --------------------------------------
// This script is totally optional. It is an example of how you can use the
// destructible versions of the objects as demonstrated in my tutorial.
// Watch the tutorial over at http://youtube.com/brackeys/.
// --------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

	public GameObject destroyedVersion; // bendir a� brotnu �tg�fu hlutsins
    public GameObject pickup; // bendir a� pickup hlutinn
    // ef eitthva� klessir � �a�
    private void OnCollisionEnter(Collision collision)
    {
        // ef �vinur e�a leikma�ur snertir hlutinn
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 9)
        {
            //gerir pickup alv�ru
            pickup.SetActive(true);
            // b�r til brotna �tg�funa
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            // ey�ir hlutinn sem scriptann tilheyrir
            Destroy(gameObject);
        }
	}

}
