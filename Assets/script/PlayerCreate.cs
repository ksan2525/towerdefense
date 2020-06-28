using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCreate : MonoBehaviour
{
    public GameObject Player;

    public GameObject Player2;

    private int Money = 0;
    public Text MoneyText;

    

    private float time = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 0.01f)
        {
            Money += 1;
            time = 0f;
        }
        
        MoneyText.text = Money.ToString() + "円";
    }

    public void OnClick()
    {
        if (Money >= Player.GetComponent<Player>().Price)
        {
            Instantiate(Player.gameObject, new Vector3(9.13f, -2.6f, 0), Quaternion.identity);
            Money -= Player.GetComponent<Player>().Price;
        }
    }

    public void OnClick2()
    {
        if (Money >= Player2.GetComponent<Player>().Price)
        {
            Instantiate(Player2.gameObject, new Vector3(9.13f, -2.6f, 0), Quaternion.identity);
            Money -= Player2.GetComponent<Player>().Price;
        }
    }
}
