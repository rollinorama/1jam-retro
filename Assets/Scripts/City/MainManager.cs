﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RE
{
    public class MainManager : MonoBehaviour
    {
        public NPCState[] _npcStates;
        public int maxStates;
        public GameState _gameState;

        private void Awake()
        {
            Debug.Log("entrou");
            MainManager[] mainManagers = FindObjectsOfType<MainManager>();

            if (mainManagers.Length > 1)
            {
                Destroy(gameObject);
            }
            else
            {
                _gameState = ScriptableObject.CreateInstance(typeof(GameState)) as GameState;
                for (int i = 0; i < _npcStates.Length; i++)
                {
                    _npcStates[i].npcStatus = NPCStatus.Initial;
                }
                DontDestroyOnLoad(gameObject);
            }

        }
    }
}
