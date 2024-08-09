using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public GameObject Square;
    // Start is called before the first frame update
    void Start()
    {
        int times = 10000;
        int check;
        int j;
        int[] binary;
        int x = 0;
        int y =0;
        int houkou = 40;//0は左1が上,2が右3が下4は左
        for (int i = 0; i <= times; i++){
            int s = i;
            Debug.Log(s);
            int length = 1;
            while(s>1){
                s = s/2;
                length++;
            }
            binary = new int[length];
            j = i;
            check = 0;
            while(j > 1){
                if(j%2 == 0){
                    binary[check]=0;
                }else{
                    binary[check]=1;
                }
                check++;
                j = j/2;
            }
            if(j==0){
                binary[length - 1] = 0;
            }
            if(j==1){
                binary[length - 1] = 1;
            }
            //for(int k=0; k<length; k++){
            //Debug.Log(binary[k]);
            //}
            int t = 0;
            while(binary[t] == 1 && t != length-1){
                t++;
            }
            if(t != length - 1){
                if(binary[t+1] == 1&& binary[t]==0){
                    houkou--;
                    Debug.Log("L");
                }else{
                    Debug.Log("R");
                    houkou++;
                }
            }else{
                Debug.Log("R");
                houkou++;
            }
            if(houkou % 4 == 0){
                for(int nya = 2;nya !=0;nya--){
                    GameObject go = Instantiate(Square);
                x--;
                go.transform.position = new Vector3(x,y,0);
                }
            }else if(houkou % 4 == 1){
                for(int nya = 2;nya !=0;nya--){
                    GameObject go = Instantiate(Square);
                y++;
                go.transform.position = new Vector3(x,y,0);
                }
            }else if(houkou % 4 == 2){
                for(int nya = 2;nya !=0;nya--){
                    GameObject go = Instantiate(Square);
                x++;
                go.transform.position = new Vector3(x,y,0);
                }
            }else if(houkou % 4 == 3){
                for(int nya = 2;nya !=0;nya--){
                    GameObject go = Instantiate(Square);
                y--;
                go.transform.position = new Vector3(x,y,0);
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
