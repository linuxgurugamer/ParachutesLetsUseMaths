﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine;

namespace ParachutesLetsUseMaths
{
    [KSPAddon(KSPAddon.Startup.EditorAny, false)]
    public class PLUM : MonoBehaviour
    {

        public static PLUM Instance;
        public static GUIElements guiPlum = new GUIElements();
        public PlumUtilities utils;
        public string dataDirectory;
        public int fileCount;
        public List<string> fileNames = new List<string>();
        


        public void Start()
        {
            if (HighLogic.LoadedSceneIsEditor)
            {
                Instance = this;
                utils = new PlumUtilities();

                dataDirectory = KSPUtil.ApplicationRootPath + "/GameData/FruitKocktail/PLUM/PluginData/";

                fileCount = Directory.GetFiles(dataDirectory).Length - 1;

                if (fileCount != 0)
                {
                    for (int x = 0; x < fileCount; x++)
                    {
                        fileNames.Add(Directory.GetFiles(dataDirectory)[x].ToString());
                    }
                }



            }
            else return;


        }

        


    }
}
