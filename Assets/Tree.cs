using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public float treeSpeed = 2.0f;

    public GameObject prefabApple;
    void Start()
    {
        Invoke("DropApple",2.0f);   
    }

    void DropApple()
    {
        GameObject Apple = Instantiate < GameObject>(prefabApple);
        Apple.transform.position = transform.position;
        Invoke("DropApple", 1.0f);
            }

    void Update()
    {
        transform.Translate(treeSpeed * Time.deltaTime, 0, 0);
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Boundries")
            treeSpeed *= -1.0f;
    }



}
