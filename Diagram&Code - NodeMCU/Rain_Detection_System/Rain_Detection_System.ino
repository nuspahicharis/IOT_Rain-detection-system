
#include "DHT.h"

#define DHTPIN 5     // Digital pin connected to the DHT sensor
#define DHTTYPE DHT22   // define dhttype

#define LDR_PIN 34 //ADC pin connected to the LDR sensor


int led = 21; //LED that tells us when data is being read/stored

// Initialize DHT sensor.
DHT dht(DHTPIN, DHTTYPE);

void setup() {
  Serial.begin(115200);
  pinMode(LDR_PIN, INPUT);
  pinMode(led, OUTPUT);
  dht.begin();
}

void loop() {
  // Wait a few seconds between measurements.
  delay(3000);

  // Reading temperature or humidity takes about 250 milliseconds!
  // Sensor readings may also be up to 2 seconds 'old' (its a very slow sensor)
  float hum = dht.readHumidity();
  // Read temperature as Celsius (the default)
  float temp = dht.readTemperature();

  // Check if any reads failed and exit early (to try again).
  if (isnan(hum) || isnan(temp)) {
    Serial.println(F("Failed to read from DHT sensor!"));
    return;
  }

  //convert analog value from LDR sensor to voltage
  int analogValue = analogRead(LDR_PIN);
  float voltage = analogValue / 4063. * 3.3;
  
  //convert voltage values from data table provided with LDR to real-life light values
  if(voltage > 0.02 && voltage  < 0.12)
    Serial.print(F("Direct sunlight ")); 
  else if (voltage > 0.12 && voltage < 0.54)
    Serial.print(F("Sunny day ")); 
  else if (voltage >0.54 && voltage<0.89)
    Serial.print(F("Light overcast day "));
  else if (voltage >0.89 && voltage<1.65)
    Serial.print(F("Overcast day "));
  else if (voltage >1.65 && voltage<2.05)
    Serial.print(F("Twilight "));
  else if (voltage >2.05 && voltage<3.00)
    Serial.print(F("Deep Twigliht "));
  else if (voltage > 3.00 && voltage <3.20)
    Serial.print(F("Full moon "));
  else  Serial.print(F("Overcast night "));

  //print values from DHT22 sensor
  Serial.print(F("Humidity: "));
  Serial.print(hum);
  Serial.print(F("%  Temperature: "));
  Serial.print(temp);
  Serial.print(F("°C"));
  Serial.println();
 
  //predict rain possibility based on sensor readings
  if(temp>0){
    if((voltage>0.89 && voltage<1.65) || voltage>3.20){
      if(hum>60){
        Serial.println("Expect rain!");
      }
      else {
        Serial.println("Rain possible!");
      }
    }
    else if((voltage>0.54 && voltage<0.89)||(voltage>1.65 && voltage<3.00)){
      Serial.println("Rain possible!");
    }
    else {
      Serial.println("No rain expected!");
    }
  }
  else{
    Serial.println("Too cold for rain!");
  }
  //set LED pin high for one second to indicate data being read
  digitalWrite(led, HIGH);
  delay(1000);

  //set LED pin low
  digitalWrite(led, LOW);
}