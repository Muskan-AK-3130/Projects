/*
 * P1.c
 *
 * Created: 14-02-2024 10:34:20
 * Author : Admin
 */ 

#include <avr/io.h>


int main(void)
{
	DDRC=0X01;//00000001
    /* Replace with your application code */
    while (1) 
    {
		PORTC=0X00;
    }
}

