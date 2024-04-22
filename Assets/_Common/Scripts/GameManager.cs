using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    private Text scoreMessage;
    private Text hpMessage;
    // Start is called before the first frame update
    void Start()
    {
        UIManager.instance.ShowBattleScreen();
        scoreMessage = GameObject.Find("Score").GetComponent<Text>();
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreMessage.text = "Score: " + score;
        UpdateHPMessage();
    }

    // PlayerのHPをhpMessageに反映させる
    
    public void UpdateHPMessage()
    {
        int hp = GameObject.FindWithTag("Player").GetComponent<PlayerController>().HP;
        hpMessage = GameObject.Find("HP").GetComponent<Text>();
        hpMessage.text = "HP: " + hp;
    }
}
