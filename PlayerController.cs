using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float hInput;
    public float VertInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * hInput *moveSpeed* Time.deltaTime);
        VertInput = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector2.up * VertInput * moveSpeed * Time.deltaTime);


    }
}
