private void HandleKick()
{
    if (Input.GetKeyDown(KeyCode.Space)) // Tombol tendangan
    {
        animator.SetTrigger("isKicking");
        FindObjectOfType<AudioManager>().PlayKickSound(); // Mainkan suara tendangan
        FindObjectOfType<AudioManager>().PlayCrowdCheer();

    }
}
