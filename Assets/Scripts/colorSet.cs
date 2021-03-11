using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorSet : MonoBehaviour
{
    public int area = 1;

    public Vector2 area1 = new Vector2(50f, 50f);
    public Vector2 area2 = new Vector2(50f, 50f);
    public Vector2 area3 = new Vector2(50f, 50f);
    public Vector2 area4 = new Vector2(50f, 50f);
    public Transform player;

    public Transform floor;

    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if ((player.position.x < (floor.localScale.x / (100f / area1.x)) - floor.localScale.x / 2) && (player.position.z < (floor.localScale.z / (100f / area1.y)) - floor.localScale.z / 2)) 
        {
            area = 1;
        }

        else if ((player.position.x > (floor.localScale.x / (100f / area2.x)) - floor.localScale.x / 2) && (player.position.z < (floor.localScale.z / (100f / area2.y)) - floor.localScale.z / 2))
        {
            area = 2;
        }

        else if ((player.position.x < (floor.localScale.x / (100f / area3.x)) - floor.localScale.x / 2) && (player.position.z > (floor.localScale.z / (100f / area3.y)) - floor.localScale.z / 2))
        {
            area = 3;
        }

        else if ((player.position.x > (floor.localScale.x / (100f / area4.x)) - floor.localScale.x / 2) && (player.position.z > (floor.localScale.z / (100f / area4.y)) - floor.localScale.z / 2))
        {
            area = 4;
        }

        else
        {
            area = 0;
        }
    }


}
