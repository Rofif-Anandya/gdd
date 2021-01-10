using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObjectMovement : MonoBehaviour
{
    Vector3 kekanan, kekiri, maju, mundur, keatas, kebawah;
    public float speed;
    public Rigidbody2D rb;
    public Animator animator;
    public GameObject GameOverPanel, RetryButton, MenuButton;
    private GameObject Player;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        GameOverPanel.SetActive(false);
        RetryButton.SetActive(false);
        MenuButton.SetActive(false);

        kekanan = new Vector3(1,0,0); 
        kekiri = new Vector3(-1,0,0);
        keatas = new Vector3(0,1,0);
        kebawah = new Vector3(0,-1,0);
        maju = new Vector3(0,0,1);
        mundur = new Vector3(0,0,-1);
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        if(Input.GetKey("right"))
            transform.position = transform.position + (kekanan * speed * Time.deltaTime);
        else if (Input.GetKey("left"))
            transform.position = transform.position + (kekiri * speed * Time.deltaTime);
        else if (Input.GetKey("up"))
            transform.position = transform.position + (keatas * speed * Time.deltaTime);
        else if (Input.GetKey("down"))
            transform.position = transform.position + (kebawah * speed * Time.deltaTime);

            
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical",movement.y); 
        animator.SetFloat("Speed",movement.sqrMagnitude);
    }
        void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.gameObject.CompareTag("enemy"))
            {
                // Destroy(Player);
                // speed = 0;
                // SceneManager.LoadScene("EndGame");
                Time.timeScale = 0f; 
                GameOverPanel.SetActive(true);
                RetryButton.SetActive(true);
                MenuButton.SetActive(true);

            }
        }

        
}
