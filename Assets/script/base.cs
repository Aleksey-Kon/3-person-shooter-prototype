using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class baseHp : MonoBehaviour
{
    public static float hp = 300;
    [SerializeField] private TMP_Text _hptext;
    [SerializeField] private Slider _hpSlider;
    private void Update()
    {
        _hptext.text = $"{hp} / 300";
        _hpSlider.value = (hp / 300);
    }
}
