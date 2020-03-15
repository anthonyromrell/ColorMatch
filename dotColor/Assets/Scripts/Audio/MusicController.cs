using UnityEngine;
using UnityEngine.Audio;

namespace Audio
{
    public class MusicController : MonoBehaviour
    {
        public AudioClip buttonSound;
        public AudioSource buttonSoundSource;

        public AudioClip catchSound;
        public AudioSource catchSource;
        public float fadeIn;
        public float fadeOut;
        public GameAction GameOver;

        public AudioMixerSnapshot inActionColor;

        public GameAction Match;

        public AudioClip matchSound;
        public AudioSource matchSource;
        public GameAction NoMatch;

        public AudioClip notMatchSound;
        public AudioSource notMatchSource;

        public AudioClip openRingSound;
        public AudioSource openRingSource;
        public AudioMixerSnapshot outActionColor;

        private void Awake()
        {
           // StartButton.StartButtonAction += PlayButtonSound;
            //RingAndWaveControl.RestartWave += ColorActionStart;
            GameOver.raiseNoArgs += ColorActionStop;
            GameOver.raiseNoArgs += PlayOpenRingSound;
            //RingAsset.RingOnWin += PlayCatchSound;
            Match.raiseNoArgs += PlayMatchSound;
            NoMatch.raiseNoArgs += PlayNotMatchSound;
        }

        public void ColorActionStart()
        {
            inActionColor.TransitionTo(fadeIn);
        }

        public void ColorActionStop()
        {
            outActionColor.TransitionTo(fadeOut);
        }

        public void PlayButtonSound()
        {
            buttonSoundSource.clip = buttonSound;
            buttonSoundSource.Play();
        }

        public void PlayOpenRingSound()
        {
            openRingSource.clip = openRingSound;
            openRingSource.Play();
        }

        public void PlayCatchSound()
        {
            catchSource.clip = catchSound;
            catchSource.Play();
        }

        public void PlayMatchSound()
        {
            matchSource.clip = matchSound;
            matchSource.Play();
        }

        public void PlayNotMatchSound()
        {
            notMatchSource.clip = notMatchSound;
            notMatchSource.Play();
        }
    }
}