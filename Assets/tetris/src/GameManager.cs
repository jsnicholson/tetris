﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the primary game manager, handles initialising this instance
/// </summary>
public class GameManager : MonoBehaviour {

// ===== PRIVATE MEMBERS =====
    private GameVariables m_variables;
    private GameGrid m_grid;
    private Spawner m_spawner;

    private AudioSource m_audioSource;
    // audio clips
    public AudioClip audio_lineClear;
// ~ PRIVATE MEMBERS

    void Start() {
        Initialise();
    }

// ===== CONSTRUCTOR =====
    public void Initialise() {
        m_variables = GetComponent<GameVariables>();
        m_grid = GameObject.Find("Grid").GetComponent<GameGrid>();
        m_grid.Initialise(this);
        m_spawner = GetComponent<Spawner>();
        m_spawner.Initialise(this);

        m_audioSource = GetComponent<AudioSource>();
    }

// ===== PUBLIC =====
    public GameVariables GetVariables() {
        return m_variables;
    }

    public GameGrid GetGrid() {
        return m_grid;
    }

    public Spawner GetSpawner() {
        return m_spawner;
    }

    public void PieceLanded() {
        /*
        bool bAnyCleared = m_grid.ClearLines();
        // play sound
        if(bAnyCleared) {
            m_audioSource.clip = audio_lineClear;
            m_audioSource.Play();
        }*/

        m_spawner.SpawnTetromino(); 
    }

} // ~GameManager