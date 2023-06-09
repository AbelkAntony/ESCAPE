using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonMovement : MonoBehaviour
{

    public GameManager game;
    
    public Rigidbody2D hexagon;

    public float shrinkSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        hexagon.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        if(transform.localScale.x <= 0.5f)
        {
            game.AddPoint();
            Destroy(gameObject);

        }

    }

}
