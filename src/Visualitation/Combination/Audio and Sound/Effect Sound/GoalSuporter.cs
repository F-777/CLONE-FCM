private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Ball"))
    {
        FindObjectOfType<AudioManager>().PlayCrowdCheer();
    }
}
