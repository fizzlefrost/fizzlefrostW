using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float enemyspeed;
    private bool flipped = false;
    private Rigidbody2D en2d;
    private Animator animatore;
    private bool isMoving = false;
    private bool Up = false;
    private bool Down = false;
    private bool Left = false;
    private bool Right = false;
    private bool IsAttacking = false;
    private bool attac = false;
    public Transform player;
    public float distanceX, distanceY, distance;
    float movingTime = 5f;
    public float chargeTime;
    float startcharge;
    AudioSource SoundKrikEnemy1;

    void Start () {
        en2d = GetComponent<Rigidbody2D>();
        animatore = GetComponent<Animator>();
        SoundKrikEnemy1 = GetComponent<AudioSource>();
    }

    void FixedUpdate () {
            
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isMoving = true;
            distanceX = player.position.x - transform.position.x;
            distanceY = player.position.y - transform.position.y;
            distance = Vector2.Distance(player.position, transform.position);
            if (distance > 3.5)
            {
                if (distanceX > 0)
                {
                    if (distanceY > 0)
                    {
                        transform.position = new Vector2(this.transform.position.x + enemyspeed, this.transform.position.y + enemyspeed);
                        Up = true;
                        Down = false;
                        Right = true;
                        Left = false;
                        isMoving = true;
                    }
                    if (distanceY < 0)
                    {
                        transform.position = new Vector2(this.transform.position.x + enemyspeed, this.transform.position.y - enemyspeed);
                        Up = false;
                        Down = true;
                        Right = true;
                        Left = false;
                        isMoving = true;
                    }
                    if (distanceY == 0)
                    {
                        transform.position = new Vector2(this.transform.position.x + enemyspeed, this.transform.position.y);
                        Up = true;
                        Down = false;
                        Right = true;
                        Left = false;
                        isMoving = true;
                    }
                }
                if (distanceX < 0)
                {
                    if (distanceY > 0)
                    {
                        transform.position = new Vector2(this.transform.position.x - enemyspeed, this.transform.position.y + enemyspeed);
                        Up = true;
                        Down = false;
                        Right = false;
                        Left = true;
                        isMoving = true;
                    }
                    if (distanceY < 0)
                    {
                        transform.position = new Vector2(this.transform.position.x - enemyspeed, this.transform.position.y - enemyspeed);
                        Up = false;
                        Down = true;
                        Right = false;
                        Left = true;
                        isMoving = true;
                    }
                    if (distanceY == 0)
                    {
                        transform.position = new Vector2(this.transform.position.x - enemyspeed, this.transform.position.y);
                        Up = false;
                        Down = true;
                        Right = false;
                        Left = true;
                        isMoving = true;
                    }
                }
                if (distanceX == 0)
                {
                    if (distanceY > 0)
                    {
                        transform.position = new Vector2(this.transform.position.x, this.transform.position.y + enemyspeed);
                        Up = true;
                        Down = false;
                        Right = true;
                        Left = false;
                        isMoving = true;
                    }
                    if (distanceY < 0)
                    {
                        transform.position = new Vector2(this.transform.position.x, this.transform.position.y - enemyspeed);
                        Up = false;
                        Down = true;
                        Right = true;
                        Left = false;
                        isMoving = true;
                    }
                }
                startcharge = 0;
            }
            else
            {
                startcharge += 0.1f;
            }
            
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
            isMoving = true;
            distanceX = player.position.x - transform.position.x;
            distanceY = player.position.y - transform.position.y;
            distance = Vector2.Distance(player.position, transform.position);
            if (!IsAttacking)
            {
                if (distance > 3.5)
                {
                    if (distanceX > 0)
                    {
                        if (distanceY > 0)
                        {
                            transform.position = new Vector2(this.transform.position.x + enemyspeed, this.transform.position.y + enemyspeed);
                            Up = true;
                            Down = false;
                            Right = true;
                            Left = false;
                            isMoving = true;
                        }
                        if (distanceY < 0)
                        {
                            transform.position = new Vector2(this.transform.position.x + enemyspeed, this.transform.position.y - enemyspeed);
                            Up = false;
                            Down = true;
                            Right = true;
                            Left = false;
                            isMoving = true;
                        }
                        if (distanceY == 0)
                        {
                            transform.position = new Vector2(this.transform.position.x + enemyspeed, this.transform.position.y);
                            Up = true;
                            Down = false;
                            Right = true;
                            Left = false;
                            isMoving = true;
                        }
                    }
                    if (distanceX < 0)
                    {
                        if (distanceY > 0)
                        {
                            transform.position = new Vector2(this.transform.position.x - enemyspeed, this.transform.position.y + enemyspeed);
                            Up = true;
                            Down = false;
                            Right = false;
                            Left = true;
                            isMoving = true;
                        }
                        if (distanceY < 0)
                        {
                            transform.position = new Vector2(this.transform.position.x - enemyspeed, this.transform.position.y - enemyspeed);
                            Up = false;
                            Down = true;
                            Right = false;
                            Left = true;
                            isMoving = true;
                        }
                        if (distanceY == 0)
                        {
                            transform.position = new Vector2(this.transform.position.x - enemyspeed, this.transform.position.y);
                            Up = false;
                            Down = true;
                            Right = false;
                            Left = true;
                            isMoving = true;
                        }
                    }
                    if (distanceX == 0)
                    {
                        if (distanceY > 0)
                        {
                            transform.position = new Vector2(this.transform.position.x, this.transform.position.y + enemyspeed);
                            Up = true;
                            Down = false;
                            Right = true;
                            Left = false;
                            isMoving = true;
                        }
                        if (distanceY < 0)
                        {
                            transform.position = new Vector2(this.transform.position.x, this.transform.position.y - enemyspeed);
                            Up = false;
                            Down = true;
                            Right = true;
                            Left = false;
                            isMoving = true;
                        }
                    }
                    startcharge = 0;
                }
                else
                {
                    IsAttacking = true;
                    isMoving = false;
                    Up = false;
                    Down = false;
                    Right = false;
                    Left = false;
                    startcharge += 0.01f;
                    if (distanceX > 0 && flipped)
                    {
                        Flip();
                        flipped = !flipped;
                    }
                    if (distanceX < 0 && !flipped)
                    {
                        Flip();
                        flipped = !flipped;
                    }
                }
            }
            else
            {
                if (startcharge >= chargeTime)
                {
                    
                    SoundKrikEnemy1.Play();
                    attac = true;
                    IsAttacking = false;
                    startcharge = 0;
                    if (distanceX > 0)
                    {
                        player.position = new Vector2(player.position.x + 1, player.position.y);
                        player.Find("backgsrnd1").transform.position = new Vector3(player.Find("backgsrnd1").transform.position.x, player.Find("backgsrnd1").transform.position.y, (player.Find("backgsrnd1").transform.position.z + 1) * 2);
                    }
                    if (distanceX < 0)
                    {
                        player.position = new Vector2(player.position.x - 1, player.position.y);
                        player.Find("backgsrnd1").transform.position = new Vector3(player.Find("backgsrnd1").transform.position.x, player.Find("backgsrnd1").transform.position.y, (player.Find("backgsrnd1").transform.position.z + 1) * 2);
                    }
                }
                else {
                    if (distance > 3.5)
                    {
                        startcharge = 0;
                    }
                    else startcharge += 0.01f;
                }
                Up = false;
                Down = false;
                Right = false;
                Left = false;
                isMoving = false;
            }
            animatore.SetFloat("distance", Mathf.Abs(distance));
            animatore.SetBool("Attack", IsAttacking);
            animatore.SetFloat("charge", startcharge);
            animatore.SetBool("up", Up);
            animatore.SetBool("down", Down);
            animatore.SetBool("right", Right);
            animatore.SetBool("left", Left);
            animatore.SetBool("isMoving", isMoving);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Up = false;
        Down = false;
        Right = false;
        Left = false;
        isMoving = false;
        IsAttacking = false;
        attac = false;
        startcharge = 0;
    }
    private void MoveAnimate(float Hor, float Ver)
    {
        distanceX = player.position.x - transform.position.x;
        distanceY = player.position.y - transform.position.y;
        if (distanceX > 0)
        {
            if (distanceY > 0)
                transform.position = new Vector2(this.transform.position.x + enemyspeed, this.transform.position.y + enemyspeed);
            else 
                transform.position = new Vector2(this.transform.position.x + enemyspeed, this.transform.position.y - enemyspeed);
        }
        if (distanceX < 0)
        {
            if (distanceY > 0)
                transform.position = new Vector2(this.transform.position.x - enemyspeed, this.transform.position.y + enemyspeed);
            else
                transform.position = new Vector2(this.transform.position.x - enemyspeed, this.transform.position.y - enemyspeed);
        }
    }
    private void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
