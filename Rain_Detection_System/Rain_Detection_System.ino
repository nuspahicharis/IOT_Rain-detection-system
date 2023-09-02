#include "DHT.h"
#include "Adafruit-Sensor.h"

#define DHTPIN 5     // Digital pin connected to the DHT sensor
#define DHTTYPE DHT22   // define dhttype

#define LDR_PIN 34 //ADC pin connected to the LDR sensor


// Initialize DHT sensor.
DHT dht(DHTPIN, DHTTYPE);

void setup() {
  Serial.begin(115200);

  pinMode(LDR_PIN, INPUT);

  dht.begin();
}

void loop() {
  // Wait a few seconds between measurements.
  delay(10000);

  // Reading temperature or humidity takes about 250 milliseconds!
  // Sensor readings may also be up to 2 seconds 'old' (its a very slow sensor)
  float h = dht.readHumidity();
  // Read temperature as Celsius (the default)
  float t = dht.readTemperature();

  // Check if any reads failed and exit early (to try again).
  if (isnan(h) || isnan(t)) {
    Serial.println("Failed to read from DHT sensor!");
    return;
  }

  int analogValue = analogRead(LDR_PIN);

  if (isnan(analogValue)){
    Serial.println("Failed to read from LDR sensor!");
  }
  float voltage = analogValue / 4063. * 3.3;
  
  if(voltage > 0.02 && voltage  < 0.12)
    Serial.print("Direct sunlight "); 
  else if (voltage > 0.12 && voltage < 0.54)
    Serial.print("Sunny day "); 
  else if (voltage >0.54 && voltage<0.89)
    Serial.print("Light overcast day ");
  else if (voltage >0.89 && voltage<1.65)
    Serial.print("Overcast day ");
  else if (voltage >1.65 && voltage<2.05)
    Serial.print("Twilight ");
  else if (voltage >2.05 && voltage<3.00)
    Serial.print("Deep Twigliht ");
  else if (voltage > 3.00 && voltage <3.20)
    Serial.print("Full moon ");
  else  Serial.print("Overcast night ");

  Serial.print("Humidity: ");
  Serial.print(h);
  Serial.print("%  Temperature: ");
  Serial.print(t);
  Serial.print("°C");
  Serial.println();

}