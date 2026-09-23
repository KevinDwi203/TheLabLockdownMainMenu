using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicManager : MonoBehaviour
{
    public AudioSource musicSource;
    public Slider musicSlider;

    private TMP_Text percentText;

    void Start()
    {
        CreatePercentText();

        musicSlider.value = musicSource.volume;

        UpdateMusicVolume(musicSlider.value);

        musicSlider.onValueChanged.AddListener(UpdateMusicVolume);
    }

    void CreatePercentText()
    {
        GameObject textObject = new GameObject("MusicPercent");

        textObject.transform.SetParent(musicSlider.transform, false);

        percentText = textObject.AddComponent<TextMeshProUGUI>();

        percentText.fontSize = 30;
        percentText.alignment = TextAlignmentOptions.Center;
        percentText.color = Color.white;
        percentText.text = "100%";

        RectTransform textRect = percentText.GetComponent<RectTransform>();

        textRect.anchorMin = new Vector2(1, 0.5f);
        textRect.anchorMax = new Vector2(1, 0.5f);
        textRect.pivot = new Vector2(0, 0.5f);

        textRect.anchoredPosition = new Vector2(20, 0);

        textRect.sizeDelta = new Vector2(80, 40);
    }

    public void UpdateMusicVolume(float value)
    {
        musicSource.volume = value;

        int percent = Mathf.RoundToInt(value * 100);

        percentText.text = percent + "%";
    }
}