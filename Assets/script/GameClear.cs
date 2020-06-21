using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{
    [SerializeField]
    float EnemyFortHP = 1000;

    public GameObject ClearText;

    // Start is called before the first frame update
    void Start()
    {
        ClearText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyFortHP < 1)
        {
            ClearText.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "Player")
        {
            
            EnemyFortHP -= 1;
        }

        if (collision.gameObject.tag == "Player2")
        {

            EnemyFortHP -= 0.5f;
        }

    }
}
