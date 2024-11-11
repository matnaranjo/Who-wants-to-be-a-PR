using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Matheus code for intro :)

public class IntroFadeIn : MonoBehaviour
{
    [SerializeField] GameObject prCard; // spinning PR card

    [SerializeField] GameObject goomPanel; // Goom Dev's display

    [SerializeField] GameObject technomancerPanel; // Technomancer display

    [SerializeField] Animator fadePanel; // Panel for transitioning displays

    [SerializeField] float timing; // Timing for how long logos will be displayed

    [SerializeField] float otherTiming; // Timing for how long screen is black

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExecuteWithDelay());
    }

    IEnumerator ExecuteWithDelay()
    {
        yield return new WaitForSeconds(timing); // Waits for logo to be displayed for long enough

        fadePanel.Play("FadeOut"); // Transitions

        yield return new WaitForSeconds(otherTiming); // Waits for transition to be complete

        technomancerPanel.SetActive(false); // takes previous logo out of the way

        fadePanel.Play("FadeIn2"); // Displays the other logo

        yield return new WaitForSeconds(timing - 0.1f); // Waits for logo to be displayed for long enough

        fadePanel.Play("FadeOut2"); // Transitions       

        yield return new WaitForSeconds(otherTiming); // Waits for transition to be complete

        goomPanel.SetActive(false); // takes Mateo's logo out of the way

        prCard.SetActive(true); // Activates PR card (it couldn't be active before because it would be in front of the logos)

        fadePanel.Play("FadeIn3"); // Displays menu
    }
}
