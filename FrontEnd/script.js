const body = document.querySelector("body");

function LoadData() {
  getMessage();
  getValues();
}

let no = "No rain expected!";
let slim = "Slim possibility of rain!";
let moderate = "Moderate possibility of rain!";
let high = "High possibility of rain!";
let cold = "Too cold for rain!";
let err = "Incorrect reading, cannot give estimate for rain";


  let valueURL = 'https://localhost:7131/api/WeatherValues/GetLastValue';
  let messageURL = 'https://localhost:7131/api/WeatherValues/GetMessage';


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

  function getValues() {
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


  anychart.onDocumentReady(function () {
  
    // add data
    var data = [
      ["2003", 1, 0, 0],
      ["2004", 4, 0, 0],
      ["2005", 6, 0, 0],
      ["2006", 9, 1, 0],
      ["2007", 12, 2, 0],
      ["2008", 13, 5, 1],
      ["2009", 15, 6, 1],
      ["2010", 16, 9, 1],
      ["2011", 16, 10, 4],
      ["2012", 17, 11, 5],
      ["2013", 17, 13, 6],
      ["2014", 17, 14, 7],
      ["2015", 17, 14, 10],
      ["2016", 17, 14, 12],
      ["2017", 19, 16, 12],
      ["2018", 20, 17, 14],
      ["2019", 20, 19, 16],
      ["2020", 20, 20, 17],
      ["2021", 20, 20, 20],
      ["2022", 20, 22, 20]
    ];

    // create a data set
    var dataSet = anychart.data.set(data);

    // map the data for all series
    var firstSeriesData = dataSet.mapAs({x: 0, value: 1});
    var secondSeriesData = dataSet.mapAs({x: 0, value: 2});
    var thirdSeriesData = dataSet.mapAs({x: 0, value: 3});
    var fourthSeriesData = dataSet.mapAs({x:0,value:2});

    // create a line chart
    var chart1 = anychart.line();
    var chart2 = anychart.line();
    var chart3 = anychart.line();
    var chart4 = anychart.line();

    // create the series and name them
    var firstSeries = chart4.line(firstSeriesData);
    firstSeries.name("Roger Federer");
    var secondSeries = chart1.line(secondSeriesData);
    secondSeries.name("Rafael Nadal");
    var thirdSeries = chart2.line(thirdSeriesData);
    thirdSeries.name("Novak Djokovic");
    var thirdSeries = chart3.line(fourthSeriesData);
    thirdSeries.name("Novake Djokovic");

    // add a legend
    //chart1.legend().enabled(true);

    // add a title
    chart1.title("Temperature");
    chart2.title("Humidity");
    chart3.title("Pressure");
    chart4.title("Light");

    // specify where to display the chart
    chart1.container("tempLine");
    chart2.container("humLine");
    chart3.container("paLine");
    chart4.container("luxLine");


    // draw the resulting chart
    chart1.draw();
    chart2.draw();
    chart4.draw();
    chart3.draw();

  });
  


