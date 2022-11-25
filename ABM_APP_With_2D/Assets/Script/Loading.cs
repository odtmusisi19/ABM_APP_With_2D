using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{

    // public Transform masukanLoadingbar;

    [SerializeField]
    private float nilaiSekarang;
    [SerializeField]
    private float nilaiKecepatan;

    // Update is called once per frame
    void Update()
    {
        if (nilaiSekarang < 20)
        {
            nilaiSekarang += nilaiKecepatan * Time.deltaTime;
            // Debug.Log((int)nilaiSekarang);
        }
        else
        {
            SceneManager.LoadScene("SampleScene");
        }
        // masukanLoadingbar.GetComponent<Image>().fillAmount = nilaiSekarang / 100;

    }
}
