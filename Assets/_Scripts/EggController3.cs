using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController3 : MonoBehaviour
{
      // Start is called before the first frame update
    public float verticalSpeed;
    public BasketController basketController;
    void Start()
    {
        verticalSpeed = Random.Range(0.019f, 0.078f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -4.7f)
        {
            basketController._live = basketController._live - 1;
            basketController.Live.text = "Live: "  + basketController._live.ToString();
            Start();
            transform.position = new Vector3(1.4f,2.3f,0.0f);
        }


        transform.position -= new Vector3(0.0f,verticalSpeed,0.0f);
        
    }

    public void reset(){
        Start();
        transform.position = new Vector3(1.4f,2.3f,0.0f);

    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        reset();
    }
}
