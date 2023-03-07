using System.Collections;
using System.Collections.Generic;
using TriLibCore;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Object GLBObject;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            TriLibGLBLoading();
        }
    }

    void TriLibGLBLoading()
    {
        string objectPath = AssetDatabase.GetAssetPath(GLBObject);

        var assetloaderOptions = AssetLoader.CreateDefaultLoaderOptions();

        AssetLoader.LoadModelFromFile(objectPath);
    }
}
