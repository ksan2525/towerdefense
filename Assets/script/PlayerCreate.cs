using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCreate : MonoBehaviour
{
    public GameObject Player;
    private int Money = 0;
    public Text MoneyText;

    [SerializeField]
    private int Price = 100;

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
        if (Money >= Price)
        {
            Instantiate(Player.gameObject, new Vector3(9.13f, -2.6f, 0), Quaternion.identity);
            Money -= Price;
        }
    }
}
