using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject target;
    public GameObject winLabel;
    public Text textScoreValue;
    int score = 0;
    bool win = false;

    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("Spawn", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (win == true) {
            CancelInvoke("Spawn");
        }
        
        if (Input.GetMouseButtonDown(0)) {
            GetComponent<AudioSource>().Play();
        }
    }

    void Spawn(){
        float randomX = Random.Range(-8f,8f);
        float ramdomY = Random.Range(-4f, 2f); ;

        Vector3 randomPosition = new Vector3(randomX, ramdomY, 0);

        Instantiate(target, 
            randomPosition, Quaternion.identity);
    }

    public void IncrementScore(){
        score++;
        textScoreValue.text = score.ToString();
        if (score >= 10) {
            win = true;
            winLabel.SetActive(win);
        }

    }
}
