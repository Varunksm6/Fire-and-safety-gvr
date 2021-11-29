using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerctrl : MonoBehaviour
{
    public float speed = 3.5f;
    public int distanceOfRaycast = 10;
    private float gravity = 10f;
    private RaycastHit _hit;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if(Physics.Raycast(ray, out _hit, distanceOfRaycast))
        {
            if(Input.GetButtonDown("Fire1")&& _hit.transform.CompareTag("cuberotate"))
            {
                _hit.transform.gameObject.GetComponent<cuberotate>().ChangeSpin();
            }
        }
        PlayerMovement();

    }

    void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 velocity = direction * speed;
        velocity = Camera.main.transform.TransformDirection(velocity);
        velocity.y -= gravity;
        controller.Move(velocity * Time.deltaTime);
    }
}
