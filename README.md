# sentrock-docker

## Sentiment Analysis Docker

### sa-frontend

- Docker build

```sh
docker build -t sa-frontend .
```

- Docker run

```sh
docker run --rm -it --name sa-frontend-cont -p 3000:80 --add-host localhost:192.168.4.136 sa-frontend
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

## Rockstar Library Docker

### rs-react

- Docker build

```sh
docker build -t rs-react .
```

- Docker run

```sh
docker run --rm -it --name rs-react-cont -p 5003:80 --add-host localhost:192.168.4.136 rs-react
```

### rs-api

- Docker build

```sh
docker build -t rs-api .
```

- Docker run

```sh
docker run --rm -it --name rs-api-cont -p 5001:80 --add-host localhost:192.168.4.136 rs-api
```

### rs-mvc

- Docker build

```sh
docker build -t rs-mvc .
```

- Docker run

```sh
docker run --rm -it --name rs-mvc-cont -p 5002:80 --add-host localhost:192.168.4.136 rs-mvc
```
