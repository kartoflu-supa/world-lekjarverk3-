// --------------------------------------
// This script is totally optional. It is an example of how you can use the
// destructible versions of the objects as demonstrated in my tutorial.
// Watch the tutorial over at http://youtube.com/brackeys/.
// --------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

	public GameObject destroyedVersion; // bendir að brotnu útgáfu hlutsins
    public GameObject pickup; // bendir að pickup hlutinn
    // ef eitthvað klessir á það
    private void OnCollisionEnter(Collision collision)
    {
        // ef óvinur eða leikmaður snertir hlutinn
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 9)
        {
            //gerir pickup alvöru
            pickup.SetActive(true);
            // býr til brotna útgáfuna
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            // eyðir hlutinn sem scriptann tilheyrir
            Destroy(gameObject);
        }
	}

}
