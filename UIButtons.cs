using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class UIButtons : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject menuButton;
    public GameObject resumeButton;
    public GameObject quiteButton;
    public Text soundOnOff;

    // FOR SOUND .
    private int num = 0;
    private bool soundTrueFalse = false;

    int level ; 

   
   

   private void Start(){
       level =  PlayerPrefs.GetInt("LevelNumber");
   }
    
    // PLAY BUTTON.
    
    public void PlayButton(){
        if(level <= 1){
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);   
        }else{
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+level);   
        }  
    }

    // MENU BUTTON.
    public void MenuButton(){
        PauseGame();
        menuPanel.SetActive(true);
        menuButton.SetActive(false);
    }

    // QUITE BUTTON.
    public void QuiteButton(){
        QuitGame();
    }

    // QUITE GAME.
    void QuitGame(){
        Application.Quit();
    }

    // PAUSE GAME.
    void PauseGame(){
        Time.timeScale = 0;
    }

    // RESUME BUTTON.
    public void ResumeButton(){
        ResumeGame();
        menuPanel.SetActive(false);
        menuButton.SetActive(true);
    }

    // RESUMEGAME.
    void ResumeGame(){
        Time.timeScale = 1;
    }

    // NEXT LEVEL.
    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Time.timeScale = 1;
        int levelNumber = SceneManager.GetActiveScene().buildIndex+1;
        PlayerPrefs.SetInt("LevelNumber",levelNumber);   
    }

    // SOUND.
    public void SoundOnOff(){
        if(num == 0){
          soundOnOff.text = "OFF";
          soundTrueFalse = true;
          AudioListener.pause = soundTrueFalse;
          num=1;
        }else if(num == 1){ 
            soundTrueFalse = false;
            soundOnOff.text = "ON"; 
            AudioListener.pause = soundTrueFalse;
            num = 0; 
        }
        
    }

    public void LastLevel(){
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }
}
