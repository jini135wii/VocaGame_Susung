using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager2 : MonoBehaviour
{
    public static string loadscene;
    public static int loadtype;
    public static void LoadSceneHandle2(string _Name, int _loadtype)
    {
        loadscene = _Name;
        loadtype = _loadtype;
        SceneManager.LoadScene("title");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
