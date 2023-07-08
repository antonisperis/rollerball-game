using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
   public float health;
   public float coins;
    // Use this for initialization
    void Start()
    {
        health = 5;
        coins = 0;
        print("current health");
        print(health);
        print("current coins");
        print(coins);
    }

    // Update is called once per frame
    void Update()
    {
        sprint();
        forceendgame();

        if (health <= 0)
        {
            print("YOU LOSE");
            endgame();
        }
    }

    void sprint()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            this.gameObject.GetComponent<UnityStandardAssets.Vehicles.Ball.Ball>().m_MovePower = 15;
            this.gameObject.GetComponent<UnityStandardAssets.Vehicles.Ball.Ball>().m_JumpPower = 4;
            this.gameObject.GetComponent<UnityStandardAssets.Vehicles.Ball.Ball>().m_MaxAngularVelocity = 35;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            this.gameObject.GetComponent<UnityStandardAssets.Vehicles.Ball.Ball>().m_MovePower = 5;
            this.gameObject.GetComponent<UnityStandardAssets.Vehicles.Ball.Ball>().m_JumpPower = 1;
            this.gameObject.GetComponent<UnityStandardAssets.Vehicles.Ball.Ball>().m_MaxAngularVelocity = 25;
        }
    }

    public void endgame()
    {


#if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif

    }

    public void forceendgame()
    {
        if (Input.GetKey("escape"))
        {
#if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif

        }
    }
}