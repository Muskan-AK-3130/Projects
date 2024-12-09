byte readFlag=0;
int analogVal=0,analogVal1=0,analogVal2=0;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  ADMUX=0x40;
  ADCSRB=0x00;
  sei();
  readFlag=0;
  ADCSRA=0xEF;
}
unsigned long timer;
unsigned long duration;
void loop() {
  // put your main code here, to run repeatedly:
  if(readFlag==1)
  {
    Serial.print(duration);
    int val=analogVal;
    Serial.println(val);
    readFlag=0;
  }
}
ISR(ADC_vect)
{
  readFlag=1;
  analogVal1=ADCL;
  analogVal2=ADCH<<8;
  analogVal=analogVal1;
  analogVal1=analogVal | analogVal2;
}

