using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour
{
    int health = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    int coins = 0;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока: " + health);
        if (health <= 0)
        {
            EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex);
        }
    }

    public void CollectCoin()
    {
        coins++;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
