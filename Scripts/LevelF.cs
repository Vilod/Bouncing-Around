using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelF : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collision)
{
   if(collision.gameObject.tag == "Player")

{
  SceneManager.LoadScene(6);
}
}
}
