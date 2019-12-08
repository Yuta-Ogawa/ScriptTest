using UnityEngine;
using System.Collections;



public class Boss {
    private int hp = 100;
    private int mp = 53;
    private int power = 25;

    public void Attack() {
        Debug.Log(this.power + "のダメージを与えた。");
    }

    public void Deffence(int damage) {
        Debug.Log(damage + "のダメージを受けた。");
        this.hp -= damage;
    }

    public void Magic(int magicconsumption) {
        if (mp > 5) {
            this.mp -= magicconsumption;
            Debug.Log("魔法攻撃をした。残りのMPは" + this.mp);

        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
           

    }
}

public class Test : MonoBehaviour {

    void Start() {
        int[] arrays = { 25, 49, 10, 18, 59 };

        for (int s = 0; s < arrays.Length; s++) {
            Debug.Log(arrays[s]);
        }
        for (int t = 4; 0 <= t; t--) {
            Debug.Log(arrays[t]);
        }
    

    
        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Deffence(3);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
    }
    void Update() {

    }
}

