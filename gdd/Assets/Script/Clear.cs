using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
      void OnTriggerEnter2D(Collider2D next)
        {
            if (next.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene("NextGame");
            }
        }
}
