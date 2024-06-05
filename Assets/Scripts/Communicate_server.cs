using System;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;
using System.Collections.Generic;


public class Communicate_server : MonoBehaviour{

    public void login(){
        login_reguqest();
    }

    public async Task login_reguqest(){
        string url = "http://192.168.0.37:5000/login/create";
        using (HttpClient client = new HttpClient()){

            // userID라는 이름에 값을 할당하여 파라미터로 추가 
            var parameters = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string, string>("userID", "22100579")
            });

            // 파라미터를 쿼리 문자열로 추가하여 URL 생성
            string requestUrl = $"{url}"; //파라미터 없음
            //string requestUrl = $"{url}?{await parameters.ReadAsStringAsync()}"; //파라미터 있음?

            HttpResponseMessage response = await client.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode){
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            } else Console.WriteLine($"Error: {response.StatusCode}");
            
        }
    }
    


}
