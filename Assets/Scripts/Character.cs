using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer SpriteRenderer;
    private Animator animator;

    [SerializeField]
    private RuntimeAnimatorController firstcontroller;
    [SerializeField]
    private RuntimeAnimatorController secondcontroller;
    public void Awake()
    {
        SpriteRenderer.sprite = Resources.Load<Sprite>($"Character{PlayerPrefs.GetInt("CharacterType")}");
        animator = GetComponent<Animator>();
    }
    private void Start()
    {
        Anim();
    }
    public void Anim()
    {
        int anime = PlayerPrefs.GetInt("CharacterType");
        if ( anime == 0 ) 
        {
            animator.runtimeAnimatorController = firstcontroller;
        }
        else
        {
            animator.runtimeAnimatorController = secondcontroller;
        }
    }

}
