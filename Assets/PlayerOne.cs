using UnityEngine;
using System.Collections;

public class PlayerOne : MonoBehaviour
{
    public GameObject meme;
    public float speed;
    private bool flipped;
    private Rigidbody2D rb2d;
    private Animator animator;
    public Transform player;
    private bool yes = false;
    private bool right = false;
    private bool left = false;
    private bool up = false;
    private bool down = true;
    private bool stand = false;
    private bool isDead = false;
    private AudioSource SoundPlayerSteps;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        SoundPlayerSteps = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = 0;
        float moveVertical = 0;
        if (Input.GetKey("left"))
        {
            moveHorizontal = -1f;
        }
        if (Input.GetKey("right"))
            moveHorizontal = 1f;
        if (Input.GetKey("down"))
            moveVertical = -1f;
        if (Input.GetKey("up"))
            moveVertical = 1f;
        MoveAnimate(moveHorizontal, moveVertical);

    }
    private void MoveAnimate(float moveHorizontal, float moveVertical)
    {

        rb2d.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);
        animator.SetFloat("speedX", Mathf.Abs(moveHorizontal));
        animator.SetFloat("speedY", Mathf.Abs(moveVertical));
        if (moveHorizontal > 0)
            right = true;
        else right = false;
        if (moveHorizontal < 0)
            left = true;
        else left = false;
        if ((moveVertical > 0) && (moveHorizontal == 0))
            up = true;
        else up = false;
        if ((moveVertical == 0) && (moveHorizontal == 0))
            stand = true;
        else stand = false;
        if ((moveVertical < 0) && (moveHorizontal == 0))
            down = true;
        else down = false;
        if ((right == true) || (left == true) || (up == true) || (down == true))
        {
            if (SoundPlayerSteps.isPlaying == false)
                SoundPlayerSteps.Play();
        }
        animator.SetBool("up", up);
        animator.SetBool("down", down);
        animator.SetBool("right", right);
        animator.SetBool("left", left);
        animator.SetBool("stand", stand);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            if (Input.GetKey("q"))
                other.gameObject.SetActive(false);
        }

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            if (Input.GetKey("q"))
                other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("PickUpLetter"))
        {
            if (Input.GetKey("e"))
                other.gameObject.SetActive(false);
        }
    }
    void Death()
    {
        if (player.Find("backgsrnd1").transform.position.z >= 100)
        {
            isDead = true;
        }
    }
}