using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_scene : MonoBehaviour
{
    public void to_store(){
        SceneManager.LoadScene("village_store");
    }

    public void to_auction(){
        SceneManager.LoadScene("village_auction");
    }

    public void to_house(){
        SceneManager.LoadScene("village_house");
    }

    public void to_smithy(){
        SceneManager.LoadScene("village_smithy");
    }

    public void to_dungeon_main(){
        SceneManager.LoadScene("dungeon_main");
    }

    public void to_dungeon_filed(){
        SceneManager.LoadScene("dungeon_filed");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
