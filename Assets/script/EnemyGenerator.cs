using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy;

    // Start is called before the first frame update


    void Start()
    {
        StartCoroutine("Generate");
    }

    IEnumerator Generate()
    {
        yield return new WaitForSeconds(5.0f);
        while (true)
        {
            Instantiate(Enemy.gameObject, new Vector3(-77.5f, -2.68f, 0), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(3, 11));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
