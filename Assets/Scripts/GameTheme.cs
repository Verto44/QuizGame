using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTheme : MonoBehaviour
{

    public Button       btnPlay;
    public Text         txtThemeName;
    public Text         txtInfoTheme;
    public GameObject   infoTheme;

    public GameObject star01;
    public GameObject star02;
    public GameObject star03;

    public string[] themeName;

    private int idTheme;
    private int numQuestions = 20;

    // Start is called before the first frame update
    void Start()
    {
        idTheme = 0;
        txtThemeName.text = themeName[idTheme];
        txtInfoTheme.text = "";

        infoTheme.SetActive(false);
        star01.SetActive(false);
        star02.SetActive(false);
        star03.SetActive(false);

        btnPlay.interactable = false;
    }

    public void SelectTheme(int id)
    {
        idTheme = id;
        txtThemeName.text = themeName[idTheme];

        int finalGrade = 0;
        int rightQuestions = 0;

        txtInfoTheme.text = "Você acertou " + rightQuestions + " de " + numQuestions;
        infoTheme.SetActive(true);
        btnPlay.interactable = true;
    }

    public void PlayTheme()
    {
        SceneManager.LoadScene("T"+idTheme.ToString());
    }
}
