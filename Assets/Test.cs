using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int mp = 53;
    
    //魔法攻撃用の関数
    public void Magic(int cost) {
              
        if (mp >= cost){
            mp -= cost;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);

        }else{
            Debug.Log("MPが足りないため魔法が使えない。");
        }
                     
    }
}

public class Test : MonoBehaviour {

    void Start() {
        int[] array = { 55, 51, 5, 24, 3 };

        //配列の要素数の分だけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
            //配列の要素を表示する
            Debug.Log(array[i]);
        }

        //配列を逆順に並べる
        for (int i = array.Length - 1; 0 <= i; i--)
        {
            //配列を表示する
            Debug.Log(array[i]);
        }

        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        for (int i = 0; i < 11; i++) {
            //魔法攻撃用の関数を呼び出す
            lastboss.Magic(5);
        }
    }
}