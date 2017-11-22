﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIButton : MonoBehaviour {

    [SerializeField] private GameObject targetObject;
    [SerializeField] private string targetMessage;
    public Color highlightColor = Color.cyan;


public void PlayGame()
{
    SceneManager.LoadScene("Game");
}

public void LaunchGameMenu()
{
    SceneManager.LoadScene("GameMenu");
}

public void ExitGame()

{
    Application.Quit();
}

public void OnMouseOver()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = highlightColor;
        }

    }

    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = Color.white;
        }

    }

    public void OnMouseDown()
    {
        transform.localScale = new Vector3(0.4f, 0.4f, 1.0f);
    }

    public void OnMouseUp()
    {
        transform.localScale = new Vector3(0.3f, 0.3f, 1.0f);
        if (targetObject != null)
        {
            targetObject.SendMessage(targetMessage);
        }
    }
}
