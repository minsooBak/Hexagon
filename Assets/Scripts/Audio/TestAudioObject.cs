using UnityEngine;
using UnityEngine.Audio;

// ������ ��� �׽�Ʈ�� ���� �׽�Ʈ Ŭ�����Դϴ�.
public class TestAudioObject : MonoBehaviour
{
    AudioManager audioManager;



    void Start()
    {
        audioManager = AudioManager.instance;
    }

    public void PlayLobbyBGM()
    {
        audioManager.BGMPlay(BGM.Lobby);
    }

    public void PlayRoundBGM()
    {
        audioManager.BGMPlay(BGM.ROUND_1);
    }


    public void UISelect()
    {
        audioManager.SFXPlay(SFX.UI_SELECT);
    }

    public void RoundStart()
    {
        audioManager.SFXPlay(SFX.ROUND_START);
    }

    public void RoundEnd()
    {
        audioManager.SFXPlay(SFX.ROUND_END);
    }

    public void Damaged()
    {
        audioManager.SFXPlay(SFX.DAMAGED);
    }



}