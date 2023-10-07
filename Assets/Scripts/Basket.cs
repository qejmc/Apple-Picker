using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidingWith = collision.gameObject;

        if (collidingWith.CompareTag("Apple"))
        {
            Destroy(collidingWith);

            int score = int.Parse(scoreGT.text);

            score += 100;

            scoreGT.text = score.ToString();

            ScoreCounter.score = score;

            if (score > HighScore.score)
            {
                HighScore.score = score;
            }

        }

        else if (collidingWith.CompareTag("Banana"))
        {
            Destroy(collidingWith);

            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();

            apScript.AppleDestroyed();
        }
    }

}
