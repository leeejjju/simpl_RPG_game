using System;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class Communicate_server : MonoBehaviour{


    public void login(){
        login_reguqest();
        SceneManager.LoadScene("button_UI");
    }

    //TODO 
    public void update_status(){
        //need to pass userID
        item_request();
        //need to get return values... structure of items and equipments

        //need to pass userID
        info_request();
        //need to get return values... structre ~~ 

        //need to calculate power/defence?? 

        //need to update displayed text with equipments
    }


    //TODO 
    public void change_equipment(){
        //need to pass userID and item ID
        change_equip_request();
        //check if success using requtn value... 
        update_status();
    }



// -----------------------------------------
    public async Task login_reguqest(){
        string url = "http://192.168.0.37:5000/login/create";
        using (HttpClient client = new HttpClient()){

            string requestUrl = $"{url}"; //파라미터 없음

            HttpResponseMessage response = await client.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode){
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            } else Console.WriteLine($"Error: {response.StatusCode}");
            
        }
    }
    
    //TODO 
    public async Task item_request(){
        string url = "http://192.168.0.37:5000/status/inventory";
        using (HttpClient client = new HttpClient()){

            var parameters = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string, string>("userID", "01010101")
            });

            // 파라미터를 쿼리 문자열로 추가하여 URL 생성
            string requestUrl = $"{url}?{await parameters.ReadAsStringAsync()}"; //파라미터 있음?

            HttpResponseMessage response = await client.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode){
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            } else Console.WriteLine($"Error: {response.StatusCode}");
            
        }
    }
    
    //TODO 
    public async Task info_request(){
        string url = "http://192.168.0.37:5000/status/inventory";
        using (HttpClient client = new HttpClient()){

            var parameters = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string, string>("userID", "01010101")
            });

            // 파라미터를 쿼리 문자열로 추가하여 URL 생성
            string requestUrl = $"{url}?{await parameters.ReadAsStringAsync()}"; //파라미터 있음?

            HttpResponseMessage response = await client.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode){
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            } else Console.WriteLine($"Error: {response.StatusCode}");
            
        }
    }
 
    //TODO 
    public async Task change_equip_request(){
        string url = "http://192.168.0.37:5000/status/changeEquipment";
        using (HttpClient client = new HttpClient()){

            var parameters = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string, string>("userID", "01010101"),
                new KeyValuePair<string, string>("equipID ", "01")
            });

            // 파라미터를 쿼리 문자열로 추가하여 URL 생성
            string requestUrl = $"{url}?{await parameters.ReadAsStringAsync()}"; //파라미터 있음?

            HttpResponseMessage response = await client.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode){
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            } else Console.WriteLine($"Error: {response.StatusCode}");
            
        }
    }
    


}
