using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer Player_spriteRenderer;
    [SerializeField]
    private float MoveSpeed = -1;

    [SerializeField]
    private float Direction = 180;

    Animator anim;
    private bool move;

    [SerializeField]
    private float EnemyHP = 10;

    public int FortHP;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, Direction, 0);

        anim = GetComponent<Animator>();
        move = true;
        GameObject.Find("Fort").GetComponent<GameOver>().FortHP = FortHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (move == true)
        {
            transform.position += new Vector3(MoveSpeed * Time.deltaTime, 0, 0);
        }
        if(EnemyHP <= 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Fort")
        {
            Player_spriteRenderer = collision.gameObject.GetComponent<SpriteRenderer>();
            if (Player_spriteRenderer.sprite.name == "Player_3")
            {
                EnemyHP -= 1;
            }
            
        if (collision.gameObject.tag == "Fort")
            {
                FortHP -= 1;
            }
            anim.SetBool("Attack", true);
            
            move = false;

        }

        if (collision.gameObject.tag == "Player2")
        {
            Player_spriteRenderer = collision.gameObject.GetComponent<SpriteRenderer>();
            if (Player_spriteRenderer.sprite.name == "sprite_1")
            {
                EnemyHP -= 2f;
            }

            anim.SetBool("Attack", true);
            move = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Player2")
        {
            anim.SetBool("Attack", false);
            move = true;
        }
    }
}
