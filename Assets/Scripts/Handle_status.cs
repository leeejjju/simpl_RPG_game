using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Handle_status : MonoBehaviour {

    Communicate_server serv = new Communicate_server();

    [SerializeField] private TextMeshProUGUI user_info;
    [SerializeField] private TextMeshProUGUI equip_armor_info;
    [SerializeField] private TextMeshProUGUI equip_weapon_info;
    [SerializeField] private TextMeshProUGUI info_msg;



    //called right after scene is loaded
    private void Awake(){
        serv.update_status();
    }


    //on item click
    public void on_item_click(){
        //if item slot is empty, warring msg display
        //if item slot is exist, make new popup to select action below 
    }

    //TODO lets just... change equip on click....... 
    //1. change equipment
    public void change_equipment(){

        //load item information


        //if item is not a equipment type, change msg_info


        //if it is,
        serv.change_equipment();
        serv.update_status();
        //change msg_info

    }

    //2. view item info
    public void view_item_info(){

        //load item  information

        //make popup display them...

    }

    //3. drop item
    public void drop_item(){

        //drop item request

    }


}
