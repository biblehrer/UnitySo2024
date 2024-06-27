using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyPrefab;

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = Wizard.Instance.transform.position;
        Vector3 direction = playerPosition - transform.position;
        transform.position += direction.normalized*Time.deltaTime * 1f;
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        //var t = (Random.value>0.5) ? 1: -1;
        float x = Random.Range(-10,10) * 1;
        float y = Random.Range(-10,10);
        if (collision2D.gameObject.tag == "Projectille")
        {       
            Instantiate(enemyPrefab, new Vector3(x,y,0), Quaternion.identity);
            Destroy(collision2D.gameObject);
            Destroy(gameObject);            
            return;
        }
        if (collision2D.gameObject.tag == "Player")
        {
            Instantiate(enemyPrefab, new Vector3(x,y,0), Quaternion.identity);
            Wizard.Instance.health -= 10;
            Destroy(gameObject);            
            return;
        }
    }
}
