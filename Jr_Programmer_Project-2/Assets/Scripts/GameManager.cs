using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool _game_Over;
    public GameObject Win_Canvas;
    public GameObject Game_Over_Canvas;
   [SerializeField] private TMP_Text Name_text;

    private void Awake()
    {
        _game_Over = false;
    }

    public void Start()
    {
        Name_text = Win_Canvas.transform.Find("Name").GetComponent<TextMeshProUGUI>();
        Name_text.text = Data_Base.instance.Player_Name.ToString();
    }


    public void win()
    {
        Win_Canvas.SetActive(true);
    }
    public void Game_Over()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }

    public void Main_Menu()
    {
        SceneManager.LoadScene(0);
    }


}
