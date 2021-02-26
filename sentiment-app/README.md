# Sentiment Analysis Application

## Authors

-   Sajal Sood sood.sa@northeastern.edu 001054338
-   Naresh Agrawal agrawal.nar@northeastern.edu 001054600
-   Leena Daryani daryani.l@northeastern.edu 001035781

## Frontend

## Requirements

-   Node.js

## Basic Installation

Make sure you have Node.js installed. Navigate to the folder `sa-frontend`

-   cd sa-frontend

Install the dependencies from the requirements using the following commands:

-   npm install

## Start the application

Run the application by running the following command:

-   npm start

The application should be running and listening for HTTP requests on port 3000 on localhost.
http://localhost:3000/

=====================================================

## Webapp

## Requirements

-   JDK
-   Maven
-   IDE

## Basic Installation

Make sure you have JDK installed. Navigate to the folder `sa-webapp`

```bash
mvn install
```

## Start the application

Navigate to the folder `sa-webapp\target`. Run the application by running the following command:

```bash
$ java -jar sentiment-analysis-web-0.0.1-SNAPSHOT.jar --sa.logic.api.url=http://localhost:5000
```

The application should be running and listening for HTTP requests on port 8080 on localhost.

## Sentiment Webapp Logic

### API Endpoints

-   testHealth
    The following API endpoint returns the health status of the `sa-webapp` application.

```bash
http://localhost:8080/testHealth
```

-   testComms
    The following API endpoint returns the communication status of the `sa-webapp` application. It returns the health status from the simultaneously running `sa-logic` application on PORT 5000

```bash
http://localhost:8080/testComms
```

-   testSentiment
    The following API endpoint returns the analysis of the `sa-webapp` application. It returns the analysis from the simultaneously running `sa-logic` application on PORT 5000

```bash
http://localhost:8080/testSentiment
```

## Logic

## Requirements

-   flask
-   flask-cors
-   requests
-   textblob==0.15.0

## Basic Installation

Make sure you have Python 3 installed. Navigate to the folder `sa-logic/sa` Install the dependencies from the requirements using the following commands:

```bash
python -m pip install -r requirements.txt
```

Download additional dependencies using the following command:

```bash
python -m textblob.download_corpora
```

## Start the application

Run the application by running the following command:

```bash
python sentiment_analysis.py
```

The application should be running and listening for HTTP requests on port 5000 on localhost.

## Sentiment Analysis Logic

### API Endpoints

-   testHealth
    The following API endpoint returns the health status of the `sa-logic` application.

```bash
http://localhost:5000/testHealth
```

-   testComms
    The following API endpoint returns the communication status of the `sa-logic` application. It returns the health status from the simultaneously running `sa-webapp` application on PORT 8080

```bash
http://localhost:5000/testComms
```
