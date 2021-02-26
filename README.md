# sentrock-docker

## Sentiment Analysis Docker

### sa-frontend

- Docker build

```sh
docker build -t sa-frontend .
```

- Docker run

```sh
docker run --rm -it --name sa-frontend-cont -p 3000:80 sa-frontend
```

### sa-webapp

- Docker build

```sh
docker build -t sa-webapp .
```

- Docker run

```sh
docker run --rm -it --name sa-webapp-cont -p 8080:8080 --add-host localhost:192.168.4.136 sa-webapp
```

### sa-logic

- Docker build

```sh
docker build -t sa-logic .
```

- Docker run

```sh
docker run --rm -it --name sa-logic-cont -p 5000:5000 --add-host localhost:192.168.4.136 sa-logic
```
