using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class FirstPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public bool canBoost;
    public GameObject laserPrefab;
    
    // fire rate is 0.5f
    // Can fire -- has the amount of time between firing passed?
    //Time.time
    public float fireRate = 0.5f;
    public float canFire = 0.0f;

    [SerializeField]
    public float speed = 5.0f;

    private void Start()
    {
        transform.position = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    private void Update()
    {
        Movement();
		 if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(1))
		 {
            if (Time.time > canFire)
            {
                Instantiate(laserPrefab, transform.position + new Vector3(0, 1f, 0), Quaternion.identity);
                canFire = Time.time + fireRate;
            }
            
		 }
	}
	private void Movement()
{
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);

    // zone out
    if (transform.position.x > 9.5f)
    {
        transform.position = new Vector3(-9.5f, transform.position.y, 0);
    }
    else if (transform.position.x < -9.5f)
    {
        transform.position = new Vector3(9.5f, transform.position.y, 0);
    }

    if (transform.position.y > 0)
    {
        transform.position = new Vector3(transform.position.x, 0, 0);
    }
    else if (transform.position.y < -4.2f)
    {
        transform.position = new Vector3(transform.position.x, -4.2f, 0);
    }
}
}