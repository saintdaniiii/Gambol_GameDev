using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Controller : MonoBehaviour
{
    public Rigidbody2D rb;
    private float moveInput;
    public float speed = 15f;

    private int topScore;
    private float score;

    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
    }

    void Update()
    {
        if (moveInput < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (moveInput > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (rb.velocity.y > 0 && transform.position.y > score)
        {
            score = transform.position.y;
        }
        topScore = (int)score;
        scoreText.text = "Score: " + topScore.ToString();

        if (PlayerPrefs.GetInt("score") <= topScore);
        PlayerPrefs.SetInt("score", topScore);

        if (rb.velocity.y < -28f)
        {
            SceneManager.LoadScene("GameoverScene");
        }
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(Input.acceleration.x * speed * Time.deltaTime, Input.acceleration.y * Time.deltaTime, 0);

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        //transform.Translate(Input.acceleration.x * speed * Time.deltaTime, Input.acceleration.y * speed * Time.deltaTime, 0);

    }
}

