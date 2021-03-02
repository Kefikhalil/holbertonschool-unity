using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public float dragSpeed = 2;
    private Vector3 dragOrigin;
    public bool isInverted;
    private int Invert;
    void Start()
    {
        {
            Invert = PlayerPrefs.GetInt("invertedY");
            if (Invert == 1)
            {
                isInverted = true;
            }
            else
                isInverted = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetMouseButtonDown(0))
            {
                dragOrigin = Input.mousePosition;
                return;
            }

            if (!Input.GetMouseButton(0)) return;

            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
            Vector3 move = new Vector3(pos.x * dragSpeed, 0, pos.y * dragSpeed);

            transform.Translate(move, Space.World);
        }

    }
}
