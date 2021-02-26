# Sentiment Analysis Logic

## Requirements

- flask
- flask-cors 
- requests 
- textblob==0.15.0

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

- testHealth
The following API endpoint returns the health status of the `sa-logic` application. 

```bash
http://localhost:5000/testHealth
```

- testComms
The following API endpoint returns the communication status of the `sa-logic` application. It returns the health status from the simultaneously running `sa-webapp` application on PORT 8080

```bash
http://localhost:5000/testComms
```

