﻿using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }

    public void ResetEvent()
    {
        PlayerInfoManager.Instance.Info.ResetVolumes();
    }
}