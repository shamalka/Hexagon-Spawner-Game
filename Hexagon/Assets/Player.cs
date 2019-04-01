using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 using System;

public class Player : MonoBehaviour
{
    float moveSpeed = 600f;

    float movement = 0f;

    float score = 0f;
    

    public Text ScoreText;
    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        score+=Time.deltaTime;
        Debug.Log(score);
        int ScoreSec = Convert.ToInt32( score % 60);;
        ScoreText.text=ScoreSec.ToString();;
    }

    private void FixedUpdate(){
        transform.RotateAround(Vector3.zero, Vector3.forward, movement* Time.fixedDeltaTime * -moveSpeed);

    }

    private void OnTriggerEnter2D(Collider2D collision){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
