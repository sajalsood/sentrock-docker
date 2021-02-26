from textblob import TextBlob
from flask import Flask, request, jsonify 
from flask_cors import CORS
import requests

app = Flask(__name__) 
CORS(app)

@app.route("/testHealth") 
def hello():
    return "Hello from python sentiment analysis flask app!"

@app.route("/testComms", methods=['GET']) 
def verify_comms_local():
    response = requests.get("http://localhost:8080/testHealth") 
    return response.text

@app.route("/analyse/sentiment", methods=['POST']) 
def analyse_sentiment():
    sentence = request.get_json()['sentence']
    polarity = TextBlob(sentence).sentences[0].polarity 
    return jsonify(
        sentence=sentence,
        polarity=polarity 
    )

@app.route("/analyse", methods=['GET']) 
def analyse_sentiment_get():
    sentence = request.args.get('sentence')
    polarity = TextBlob(sentence).sentences[0].polarity 
    return str(polarity)

if __name__ == '__main__': 
    app.run(host='0.0.0.0', port=5000)