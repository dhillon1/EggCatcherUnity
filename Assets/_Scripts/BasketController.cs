using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class BasketController : MonoBehaviour
{
    public Camera camera;
    public AudioSource music;

    public Text Live;
    public Text Score;

    public int _live = 4;
    public int _score = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2 (Mathf.Clamp(mousePosition.x,-1.48f,1.48f),Mathf.Clamp(mousePosition.y,-4f,1.38f));
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        music.Play();
        _score  = _score + 10;
        Score.text = "Score : " + _score.ToString(); 

        
    }

}
