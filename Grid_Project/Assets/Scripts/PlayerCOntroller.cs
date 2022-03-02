using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCOntroller : MonoBehaviour
{
    [SerializeField] float Range = 2f;
    float speed = 5;
    public bool DownEmpty = false;
    public bool UpEmpty = false;
    public bool Rempty = false;
    public bool Lempty = false;
    public GameObject BackRay,UpRay,Rray,Lray;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0.8f, 0); 
    }

    // Update is called once per frame
    void Update()
    {
        
        ShootRayDown();
        ShootRayUp();
        ShootRayRight();
        ShootRayLeft();
        Player_Movement();
    }

    private void ShootRayLeft()
    {
        Vector3 direction = Vector3.down;
        Ray ray = new Ray(Lray.transform.position, transform.TransformDirection(direction * Range));
        Debug.DrawRay(Lray.transform.position, transform.TransformDirection(direction * Range), Color.red);

        if (Physics.Raycast(ray, out RaycastHit hitinfo, Range))
        {
            if (hitinfo.collider.tag == "Cube")
            {
                //Debug.Log("Collided with " + hitinfo.collider.gameObject.name);
                Lempty = false;
            }
            else if (hitinfo.collider.tag == "Plane")
            {
                //Debug.Log("Collided with " + hitinfo.collider.gameObject.name);
                Lempty = true;
            }
        }
    }

    private void ShootRayRight()
    {
        Vector3 direction = Vector3.down;
        Ray ray = new Ray(Rray.transform.position, transform.TransformDirection(direction * Range));
        Debug.DrawRay(Rray.transform.position, transform.TransformDirection(direction * Range), Color.red);

        if (Physics.Raycast(ray, out RaycastHit hitinfo, Range))
        {
            if (hitinfo.collider.tag == "Cube")
            {
                // Debug.Log("Collided with " + hitinfo.collider.gameObject.name);
                Rempty = false;
            }
            else if (hitinfo.collider.tag == "Plane")
            {
                //Debug.Log("Collided with " + hitinfo.collider.gameObject.name);
                Rempty = true;
            }
        }
    }

    void ShootRayDown()
    {
        Vector3 direction = Vector3.down;
        Ray ray = new Ray(BackRay.transform.position , transform.TransformDirection(direction * Range));
        Debug.DrawRay(BackRay.transform.position, transform.TransformDirection(direction * Range),Color.red);

        if (Physics.Raycast(ray, out RaycastHit hitinfo, Range))
        {
            if (hitinfo.collider.tag == "Cube")
            {
                // Debug.Log("Collided with " + hitinfo.collider.gameObject.name);
                DownEmpty = false;
            }
           else if (hitinfo.collider.tag == "Plane")
            {
                // Debug.Log("Collided with " + hitinfo.collider.gameObject.name);
                DownEmpty = true;
            }
        }
     }
    void ShootRayUp()
    {
        Vector3 direction = Vector3.down;
        Ray ray = new Ray(UpRay.transform.position, transform.TransformDirection(direction * Range));
        Debug.DrawRay(UpRay.transform.position, transform.TransformDirection(direction * Range), Color.red);

        if (Physics.Raycast(ray, out RaycastHit hitinfo, Range))
        {
            if (hitinfo.collider.tag == "Cube")
            {
                //Debug.Log("Collided with " + hitinfo.collider.gameObject.name);
                UpEmpty = false;
            }
            else if (hitinfo.collider.tag == "Plane")
            {
                // Debug.Log("Collided with " + hitinfo.collider.gameObject.name);
                UpEmpty = true;
            }
        }
    }
    void Player_Movement()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && Rempty == false )
        {
            transform.Translate(new Vector3(2, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && Lempty == false)
        {
            transform.Translate(new Vector3(-2, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && UpEmpty == false)
        {
            transform.Translate(new Vector3(0, 0, 2));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && DownEmpty == false)
        {
            transform.Translate(new Vector3(0, 0, -2));
        }
    }
    
}
