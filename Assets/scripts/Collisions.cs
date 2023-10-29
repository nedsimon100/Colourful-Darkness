using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
    public bool isPlayer;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isPlayer == true)
        {
            if(collision.gameObject.tag == "Finish")
            {
                Debug.Log("Level Complete");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
            if (collision.gameObject.tag == "Enemy")
            {
                Debug.Log("dead");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
      //  else
      //  {
      //      if (collision.gameObject.tag == "enemy")
      //      {
      //          Destroy(this);
      //      }
      //  }
        
    }

}
