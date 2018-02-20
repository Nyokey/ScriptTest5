using System.Collections;
using UnityEngine;

public class Test1 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        // 要素数５の配列を初期化する
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 49;
        array[1] = 34;
        array[2] = 35;
        array[3] = 15;
        array[4] = 25;

        // 配列の要素を順番に表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // 配列の要素を逆順に表示する
        for (int p = 4; p >= 0; p--)
        {
            Debug.Log(array[p]);
        }
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
