const body = document.querySelector("body");

function LoadData() {
  getMessage();
  getLastValue();
  getAllValues();
  
}

  let no = "No rain expected!";
  let slim = "Slim possibility of rain!";
  let moderate = "Moderate possibility of rain!";
  let high = "High possibility of rain!";
  let cold = "Too cold for rain!";
  let err = "Incorrect reading, cannot give estimate for rain";

  let valueCounter = 0;
  let valueLables =[];
  let valueData = [];
  
  let valueURL = 'https://localhost:7131/api/WeatherValues/GetLastValue';
  let messageURL = 'https://localhost:7131/api/WeatherValues/GetMessage';
  let allValuesURL = 'https://localhost:7131/api/WeatherValues/GetAllValues';

  let ctxTemp = document.getElementById("tempLine");
  let ctxHum = document.getElementById("humLine");
  let ctxPa = document.getElementById("paLine");
  let ctxLux = document.getElementById("luxLine");



  function getMessage() {
    setInterval(async function(){
      await fetch(messageURL)
      .then((r) => {
        if (r.status !== 200) {
          alert('Server javlja grešku: ' + r.status);
          return;
        }
        r.json().then((x) => {
          document.getElementById("message").innerHTML = `${x.message}`;

          if(x.message===no){
            document.body.style.backgroundImage = "url('./Backgrounds/sunnyday.jpg')";
            document.getElementById("message-container").style.backgroundColor = "lightyellow";
            document.getElementById("message-container").style.color="black";
            document.getElementById("title").style.color = "whitesmoke";
          }
          if(x.message===slim || x.message===moderate){
            document.body.style.backgroundImage = "url('./Backgrounds/overcast.jpg')";
            document.getElementById("message-container").style.backgroundColor = "lightgrey";
            document.getElementById("message-container").style.color="black";
          }
          if(x.message===high){
            document.body.style.backgroundImage = "url('./Backgrounds/rainyday.jpg')";
            document.getElementById("message-container").style.backgroundColor = "#3b7b91";
            document.getElementById("message-container").style.color = "whitesmoke";
            document.getElementById("title").style.color = "whitesmoke";
          }
          if(x.message===cold){
            document.body.style.backgroundImage = "url('./Backgrounds/snowysky.jpg')";
            document.getElementById("message-container").style.backgroundColor = "whitesmoke";
            document.getElementById("message-container").style.color="black";
          }
          if(x.message===err){
            document.body.style.backgroundImage = "url()";
          }
        });
      })
      .catch((err) => {
        alert('Greška u komunikaciji sa serverom: ' + err);
      });
    },1000);
  }

  function getLastValue() {
    setInterval(async function(){
      await fetch(valueURL)
      .then((r) => {
        if (r.status !== 200) {
          alert('Server javlja grešku: ' + r.status);
          return;
        }
        r.json().then((x) => {
          document.getElementById("tempvalue").innerHTML = `${x.temperature}`;
          document.getElementById("humvalue").innerHTML = `${x.humidity}`;
          document.getElementById("pavalue").innerHTML = `${x.pressure}`;
          document.getElementById("luxvalue").innerHTML = `${x.light}`;

          //temperature
          if(parseInt(x.temperature)>25){
            document.getElementById("temperature").style.backgroundColor = "orange";
          }
          else if(parseInt(x.temperature) <=0){
            document.getElementById("temperature").style.backgroundColor = "lightskyblue";
          }
          else{
            document.getElementById("temperature").style.backgroundColor = "lightyellow";
          }

          //humidity
          if(parseInt(x.humidity)<30){
            document.getElementById("humidity").style.backgroundColor = "lightblue";
          }
          else if(parseInt(x.humidity)>60){
            document.getElementById("humidity").style.backgroundColor = "lightpink";
          }
          else {
            document.getElementById("humidity").style.backgroundColor = "lavender";
          }

          //pressure
          if(parseInt(x.pressure)<1000){
            document.getElementById("pressure").style.backgroundColor = "lightcyan";
          }
          else if((x.pressure)>1000){
            document.getElementById("pressure").style.backgroundColor = "darkcyan";
          }
          else{
            document.getElementById("pressure").style.backgroundColor = "cyan";
          }

          //light
          if(parseInt(x.light)<=50){
            document.getElementById("light").style.backgroundColor = "lightsalmon";
          }
          else if(parseInt(x.light)>50 && parseInt(x.light)<=1000){
            document.getElementById("light").style.backgroundColor = "lightgrey";
          }
          else if(parseInt(x.light)>1000 && parseInt(x.light)<=15000){
            document.getElementById("light").style.backgroundColor = "white";
          }
          else{
            document.getElementById("light").style.backgroundColor = "lightblue";
          }
        });
      })
      .catch((err) => {
        alert('Greška u komunikaciji sa serverom: ' + err);
      });
    },1000);
  }

  function getAllValues() {
    setInterval(async function () {
      await fetch(allValuesURL)
        .then((r) => {
          if (r.status !== 200) {
            alert("Server javlja grešku: " + r.status);
            return;
          }
          r.json().then((x) => {

            TempValues = [];
            HumValues = [];
            PaValues = [];
            LuxValues =[];

            valueCounter = 0;
            valueLables = [];


            for (const obj of x) {
              valueCounter++;
              valueLables.push(valueCounter);
              TempValues.push(
                obj.temperature
              );
              HumValues.push(
                x.humidity
              );
              PaValues.push(
                x.pressure
              );
              LuxValues.push(
                x.light
              );
            }



            //temperature chart update
            temperatureChart.destroy();
            console.log(x[valueCounter-1].temperature);
            var tempBorder = "yellow";
            if(x[valueCounter-1].temperature>30)
              tempBorder = "orange";
            else if(x[valueCounter-1].temperature<1)
              tempBorder = "blue";
            temperatureChart = new Chart(ctxTemp, {
              type : 'line',
              data : {
                labels : valueLables,
                datasets : [
                    {
                      data : TempValues,
                      label : "Temperature",
                      borderColor : tempBorder,
                      fill : false
                    }]
              },
              options : {
                title : {
                  display : true,
                  text : 'Chart JS Line Chart Example'
                },
                animation:false
              }
            });
            




          });
        })
        .catch((err) => {
          alert("Greška u komunikaciji sa serverom: " + err);
        });
    }, 1000);
  }

  var temperatureChart = new Chart(ctxTemp, {
    type : 'line',
    data : {
      labels : [],
      datasets : [
          {
            data : [],
            label : "",
            borderColor : "darkgrey",
            fill : false
          }]
    },
    options : {
      title : {
        display : true,
        text : 'Chart JS Line Chart Example'
      },
      animation:false
    }
  });
  
  

  var humidity = new Chart(ctxHum, {
    type : 'line',
    data : {
      labels : [],
      datasets : [
          {
            data : [],
            label : "Humidity",
            borderColor : "#3cba9f",
            fill : false
          }]
    },
    options : {
      title : {
        display : true,
        text : 'Chart JS Line Chart Example'
      }
    }
  });

  var pressure = new Chart(ctxPa, {
    type : 'line',
    data : {
      labels : [],
      datasets : [
          {
            data : [],
            label : "Pressure",
            borderColor : "#3cba9f",
            fill : false
          }]
    },
    options : {
      title : {
        display : true,
        text : 'Chart JS Line Chart Example'
      }
    }
  });

  var light = new Chart(ctxLux, {
    type : 'line',
    data : {
      labels : [],
      datasets : [
          {
            data : [],
            label : "Light",
            borderColor : "#3cba9f",
            fill : false
          }]
    },
    options : {
      title : {
        display : true,
        text : 'Chart JS Line Chart Example'
      }
    }
  });

  



