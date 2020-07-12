using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    public int FortHP = 1000;

    public GameObject GameOverText;

    // Start is called before the first frame update
    void Start()
    {
        GameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (FortHP < 1)
        {
            GameOverText.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "enemy")
        {
            FortHP -= 1;
         
        }
    }
    
        
    
}
