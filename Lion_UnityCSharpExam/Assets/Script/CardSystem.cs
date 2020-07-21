using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class CardSystem : MonoBehaviour
{
    public Button button;
    public List<GameObject> cards = new List<GameObject>();
    private string[] type = { "Spades", "Diamond", "Heart", "Club" };

    private void Start()
    {
        GetAllCard();
        Sort();
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) Application.LoadLevel("第四題");
    }
    private void GetAllCard()
    {
        for (int i = 0; i < type.Length; i++)
        {
            for (int j = 1; j < 14; j++)
            {
                string number = j.ToString();
                switch (j)
                {
                    case 1:
                        number = "A";
                        break;
                    case 11:
                        number = "J";
                        break;
                    case 12:
                        number = "Q";
                        break;
                    case 13:
                        number = "K";
                        break;
                }
                GameObject card = Resources.Load<GameObject>("PlayingCards_" + number + type[i]);
                cards.Add(card);
            }
        }
    }
    public void Sort()
    {
        var sort = from card in cards
                   where card.name.Contains(type[3]) || card.name.Contains(type[2]) || card.name.Contains(type[1]) || card.name.Contains(type[0])
                   select card;
        foreach (var item in sort) Instantiate(item, transform);
        StartCoroutine(SetChildPosition());
    }
    private IEnumerator SetChildPosition()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.eulerAngles = new Vector3(180, 0, 0);
            child.localScale = Vector3.one * 20;
            float x = i % 13;
            int y = i / 13;
            child.position = new Vector3((x - 6)*1.5f, y*2-1, 0);

            yield return null;
        }
    }
    public void DeleteEven()
    {
        for (int i = 0; i < 52; i++)
        {
            if ((i % 2 == 0 && i < 13 ))continue;
            if ((i % 2 == 1 && i >= 13 && i < 26)) continue;
            if ((i % 2 == 0 && (i < 39 && i >=26))) continue;
            if ((i % 2 == 1 && i >= 39)) continue;

            GameObject even = transform.GetChild(i).gameObject;
            Destroy(even);
            button.interactable = false;
        }
    }
}
