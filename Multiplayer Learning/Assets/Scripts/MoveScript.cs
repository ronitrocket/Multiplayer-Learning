using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MoveScript : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody rigidbody;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.GetComponent<NetworkIdentity>().isLocalPlayer)
        {

            //Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            if (Input.GetKey(KeyCode.P))
            {

            }

            transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
            //Moves Left and right along x Axis                               //Left/Right
            transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
            //rigidbody.AddForce(direction * Time.deltaTime * moveSpeed);

            transform.rotation = Quaternion.LookRotation(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")), Vector3.up);
        }

    }
}
