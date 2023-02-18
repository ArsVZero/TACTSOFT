int[] octalValues = { 0, 1, 10, 11, 100, 101, 110, 111 };
long long octalNumber, temporary, binaryNumber, place;
int rem;

/* Input Octal number from user */
printf("Enter any Octal number: ");
scanf("%lld", &octalNumber);
temporary = octalNumber;

binaryNumber = 0;
place = 1;

/* Convert octalNumber to binaryNumber */
while (temporary > 0)
{
    /* Extract the last digit of octalNumber */
    rem = temporary % 10;

    /*
     * Get the binaryNumber equivalent of octalNumber digit
     * add it to the binaryNumber variable
     */
    binaryNumber = (octalValues[rem] * place) + binaryNumber;

    /* Remove the last octalNumber digit */
    temporary /= 10;

    /* Increase the place value */
    place *= 1000;
}

printf("Octal number = %lld\n", octalNumber);
printf("Binary number = %lld", binaryNumber);