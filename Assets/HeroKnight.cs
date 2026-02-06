// Ќќ¬јя ‘”Ќ ÷»я: —мерть при входе в триггер (касании сферы)
private void OnTriggerEnter2D(Collider2D collision)
{
    // ѕровер€ем тег "DeathZone"
    if (collision.CompareTag("DeathZone"))
    {
        // »спользуем ту же логику, что и при нажатии клавиши 'e'
        if (!m_rolling)
        {
            m_animator.SetBool("noBlood", m_noBlood);
            m_animator.SetTrigger("Death");
        }
    }
}
