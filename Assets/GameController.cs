using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
  [SerializeField] private Text positionText;
  [SerializeField] private Transform player;


  void Start()
  {
    Load();
    UpdateUI();
  }

  public void Save()
  {
    PlayerPrefs.SetFloat(Prefs.PositionX, player.position.x);
    PlayerPrefs.SetFloat(Prefs.PositionY, player.position.y);
    UpdateUI();
  }

  public void Load()
  {
    float x = PlayerPrefs.GetFloat(Prefs.PositionX, 0);
    float y = PlayerPrefs.GetFloat(Prefs.PositionY, 0);
    player.position = new Vector2(x, y);
  }

  void UpdateUI() => positionText.text = $"Saved Position ({player.position.x}, {player.position.y})";
}
