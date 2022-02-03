using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void facebook()
    {
        Application.OpenURL("https://www.facebook.com/profile.php?id=100017130693739");
    }
    public void github()
    {
        Application.OpenURL("https://github.com/Kefikhalil");
    }
    public void linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/khalil-kefi/");
    }
}
