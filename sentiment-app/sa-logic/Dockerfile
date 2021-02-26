FROM arm64v8/python:3.9.2-slim
COPY sa /app
WORKDIR /app
RUN python3 -m pip install -r requirements.txt && \
python3 -m textblob.download_corpora 
EXPOSE 5000
ENTRYPOINT ["python3"]
CMD ["sentiment_analysis.py"]