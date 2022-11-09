    private IEnumerator ObjectShake(float shakeTime, float shakeAmount)
    {
        Vector3 initialPosition = shakeOBJ.transform.position;

        float time = shakeTime;
        float amount = shakeAmount;

        while (true)
        {
            if (time > 0.1f)
            {
                shakeOBJ.transform.position = Random.insideUnitSphere * amount + initialPosition;
                time -= Time.deltaTime;

                amount -= 1 / (time * 100);
            }
            else
            {
                shakeOBJ.transform.position = initialPosition;
                yield break;
            }

            yield return wait001;
        }
    }
