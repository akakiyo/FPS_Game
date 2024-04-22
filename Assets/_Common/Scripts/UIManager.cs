using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject battleScreen;
    public GameObject resultScreen;

    // Start is called before the first frame update
    void Start()
    {
        ShowBattleScreen();
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowBattleScreen()
    {
        battleScreen.SetActive(true);
        resultScreen.SetActive(false);
    }

    // バトル画面を表示し、ホーム画面を非表示にする
    public void ShowResultScreen()
    {
        battleScreen.SetActive(false);
        resultScreen.SetActive(true);
    }
}
