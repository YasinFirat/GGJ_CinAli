using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class UiControl : MonoBehaviour
{
    bool isVoidceOn = true;
    public void LoadScene(int id)
    {
        SceneManager.LoadSceneAsync(id);
        
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void VoiceOff(AudioMixer s)
    {
        s.SetFloat("volumeMusic",-80);
    } public void VoiceOn(AudioMixer s)
    {
        s.SetFloat("volumeMusic",0);
    }
   
}
