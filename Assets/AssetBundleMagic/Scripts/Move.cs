using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        controller.SimpleMove(transform.forward * speed * Input.GetAxis("Vertical"));
        transform.Rotate(transform.up, 8f * Input.GetAxis("Horizontal"));

    }
}
