using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer Enemy_spriteRenderer;

    [SerializeField]
    private float MoveSpeed = -1;


    [SerializeField]
    private float Direction = 0;

    Animator anim;
    private bool move;

    private bool stay;

    [SerializeField]
    private int PlayerHP = 10;


    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, Direction, 0);
        anim = GetComponent<Animator>();
        move = true;
        stay = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (move == true)
        {
            transform.position += new Vector3(MoveSpeed * Time.deltaTime, 0, 0);
        }

        if (PlayerHP <= 1)
        {
            Destroy(gameObject);
        }
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "EnemyFort")
        {
            Enemy_spriteRenderer = collision.gameObject.GetComponent<SpriteRenderer>();
            if (Enemy_spriteRenderer.sprite.name == "Enemy_3")
            {
                PlayerHP -= 1;
            }
            
            anim.SetBool("Attack", true);
            move = false;
            if (stay == true)
            {
                transform.position += new Vector3(MoveSpeed / 1000f * Time.deltaTime, 0, 0);
            }
            else
            {
                transform.position -= new Vector3(MoveSpeed / 1000f * Time.deltaTime, 0, 0);
            }
            stay = !stay;
            Debug.Log("stay");
            
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            anim.SetBool("Attack",false);
            move = true;
            Debug.Log("exit");
        }
    }
}
