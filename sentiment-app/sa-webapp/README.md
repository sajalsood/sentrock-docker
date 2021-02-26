# Sentiment Webapp

## Requirements

- JDK
- Maven 
- IDE 

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

- testHealth
The following API endpoint returns the health status of the `sa-webapp` application. 

```bash
http://localhost:8080/testHealth
```

- testComms
The following API endpoint returns the communication status of the `sa-webapp` application. It returns the health status from the simultaneously running `sa-logic` application on PORT 5000

```bash
http://localhost:8080/testComms
```
- testSentiment
The following API endpoint returns the analysis of the `sa-webapp` application. It returns the analysis from the simultaneously running `sa-logic` application on PORT 5000

```bash
http://localhost:8080/testSentiment
```

