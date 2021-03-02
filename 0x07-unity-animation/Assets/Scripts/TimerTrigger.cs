using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            if (other.GetComponent<Timer>().enabled == false)
                other.GetComponent<Timer>().enabled = true;
        }
    }
}
