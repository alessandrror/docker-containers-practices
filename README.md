# User Registration API

This repository contains an API for user registration written in **[Rust](https://www.rust-lang.org/)** using a database in [PostgreSQL](https://www.postgresql.org/).

It is using **[Docker](https://www.docker.com/)** to isolate the resources and make it easy to run it on any device with any OS. The main content is allocated inside the `src` folder.

## Getting Started

The requirement to run this project is just to install **Docker** so you can check it out how to install it on your OS (is available on any Unix like system as Linux and OSX and also on Windows).

Once installed you just need to run the containers using the following commands

To start the database container

```sh
docker compose up db
```

To build the application image

```sh
docker compose build
```

To start the database container

```sh
docker compose up rustapp
```

And thats it! Now you can watch the containers running using the next command

```sh
docker ps -a
```

## About

This project is a followed guide by [FrancescoXX](https://github.com/FrancescoXX) shared in his [YouTube channel](https://www.youtube.com/@francescociulla). You can find the original code in this [repository](https://github.com/FrancescoXX/rust-crud-api).
