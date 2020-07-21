using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class random : MonoBehaviour
{
    public Sprite[] spritePool;
    private int count;
    private bool randomstart = false;

    void Start()
    {
        spritePool = Resources.LoadAll<Sprite>("Sprites");
    }

    // Update is called once per frame
    void Update()
    {
        if (randomstart == true)
        {
            if (count < 75)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = spritePool[Random.Range(0, spritePool.Length)];
                count += 1;
                if (count == 74)
                {
                    count = 0;
                    randomstart = false;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.O)) Application.LoadLevel("第一題");
        if (Input.GetKeyDown(KeyCode.P)) Application.LoadLevel("第三題");
    }
    public void Click()
    {
        randomstart = true;
    }

}
