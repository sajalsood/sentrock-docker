# sentrock-docker

## Sentiment Analysis Docker

### sa-frontend

- Docker build

```sh
docker build -t sajalsood/sa-frontend:tagname .
```

- Docker run

```sh
docker run --rm -it --name sa-frontend-cont -p 3000:80 --add-host localhost:192.168.4.136 sajalsood/sa-frontend:tagname
```

### sa-webapp

- Docker build

```sh
docker build -t sajalsood/sa-webapp:tagname .
```

- Docker run

```sh
docker run --rm -it --name sa-webapp-cont -p 8080:8080 --add-host localhost:192.168.4.136 sajalsood/sa-webapp:tagname
```

### sa-logic

- Docker build

```sh
docker build -t sajalsood/sa-logic:tagname .
```

- Docker run

```sh
docker run --rm -it --name sa-logic-cont -p 5000:5000 --add-host localhost:192.168.4.136 sajalsood/sa-logic:tagname
```

## Rockstar Library Docker

### rs-react

- Docker build

```sh
docker build -t sajalsood/rs-react:tagname .
```

- Docker run

```sh
docker run --rm -it --name rs-react-cont -p 5003:80 --add-host localhost:192.168.4.136 sajalsood/rs-react:tagname
```

### rs-api

- Docker build

```sh
docker build -t sajalsood/rs-api:tagname .
```

- Docker run

```sh
docker run --rm -it --name rs-api-cont -p 5001:80 --add-host localhost:192.168.4.136 sajalsood/rs-api:tagname
```

### rs-mvc

- Docker build

```sh
docker build -t sajalsood/rs-mvc:tagname .
```

- Docker run

```sh 
docker run --rm -it --name rs-mvc-cont -p 5002:80 --add-host localhost:192.168.4.136 sajalsood/rs-mvc:tagname
```
