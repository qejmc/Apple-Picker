using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")] //fields will not be changeable when game is running
    // Start is called before the first frame update
    public GameObject applePrefab;
    public GameObject bananaPrefab;

    public static float speed = 8f; //speed of the tree
    public float leftAndRightEdge = 10f; //distance before turning
    public float changeDirChance = 0.01f;
    public static float banana_drop_chance = 0.5f;
    public static float appleDropDelay = 1f;

    void Start()
    {
        Invoke("DropApple", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        //Basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x < -leftAndRightEdge)
        { 
            speed = Mathf.Abs(speed); 
        }
        else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }

    }

    private void FixedUpdate()
    {
        if (Random.value < changeDirChance)
        {
            speed *= -1; //change direction
        }
    }

    void DropApple()
    {
        if(Random.value < banana_drop_chance)
        {
            GameObject banana = Instantiate<GameObject>(bananaPrefab);
            banana.transform.position = transform.position;
        }
        else
        {
            GameObject apple = Instantiate<GameObject>(applePrefab);
            apple.transform.position = transform.position;
        }
        Invoke("DropApple", appleDropDelay);
    }
}
