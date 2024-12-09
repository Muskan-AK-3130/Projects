/*
 * TransReceiver.c
 *
 * Created: 18-03-2024 10:24:21
 * Author : Admin
 */ 

#include <avr/io.h>
#include <avr/interrupt.h>
char J;
int main(void)
{
	DDRB=0xFF;
	PORTB=0x00;
	UDR0='H';
	UBRR0=0x67;
	UCSR0A=0x00;
	UCSR0B=0xD8;
	UCSR0C=0x06;
	sei();
    /* Replace with your application code */
    while (1) 
    {
		if(J=='A')
			PORTB=0xFF;
		if(J=='B')	
			PORTB=0x00;
    }
}
ISR((USART_TX_vect))
{
	UDR0='g';//UDR0 is a Data Register of USART
}
ISR(USART_RX_vect)
{
	//PORTB=0xFF;//If you press any key from the keyboard, it will ON the LED on the Ardiuno
// 	if(UDR0=='A')
// 	{
// 		PORTB=0xFF;
// 	}
// 	if(UDR0=='B')
// 	{
// 		PORTB=0x00;
// 	}
	J=UDR0;
}

