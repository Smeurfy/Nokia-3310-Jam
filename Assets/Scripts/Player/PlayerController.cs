using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Transform arrow;
    [SerializeField]
    private float rotationSpeed;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private Transform auxVector;

    private Rigidbody2D rb;
    private Vector2 jumpDir;
    private AudioSource audio;

    public bool isStuck { get; set; } = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //clock wise rotation
        var horizontal = Input.GetAxis("Horizontal") * (-1);

        //rotate arrow
        arrow.RotateAround(this.transform.position, Vector3.forward, horizontal * rotationSpeed);

        if (isStuck)
        {
            rb.gravityScale = 0;
            transform.position = transform.position;
        }

    }

    public void Jump()
    {
        //Undo stuck
        if (isStuck)
        {
            rb.gravityScale = 1;
            isStuck = false;
        }

        //calculate jump direction and apply force
        jumpDir = (auxVector.position - transform.position) * jumpForce;

        //apply force
        rb.AddForce(jumpDir, ForceMode2D.Impulse);

        //play jump sound
        audio.Play();
    }
}
