using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    private Text scoreMessage;
    // Start is called before the first frame update
    void Start()
    {
        scoreMessage = GameObject.Find("Score").GetComponent<Text>();
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
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
    }
}
