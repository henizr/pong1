using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float speed = 15;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newPosY = transform.position.y + Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.position = new Vector2(transform.position.x, newPosY);
    }
}
