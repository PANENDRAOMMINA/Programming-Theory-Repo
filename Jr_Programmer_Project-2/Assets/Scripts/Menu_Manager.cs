using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Menu_Manager : MonoBehaviour
{
    public TMP_InputField player_input;

    public void Play()
    {
        Data_Base.instance.Player_Name = player_input.text;
        SceneManager.LoadScene("Game_Play");
    }
   public void exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }

}
