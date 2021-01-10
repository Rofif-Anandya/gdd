using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour {
    public void OnMouseClick() {
        Level1();
    }
    public void Menu() {
        SceneManager.LoadScene("MainMenu");
    }
    public void Level1() {
        SceneManager.LoadScene("Forest");
    }
}