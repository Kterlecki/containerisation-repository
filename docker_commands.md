### Docker Build
``dotnet build -t {Tag-To-Attach-To-Image} .``

#### If you want to provide path yo your Dockerfile
`` docker build -t {Tag-To-Attach-To-Image} -f /path/to/Dockerfile . ``

#### Build an image with no cache
`` docker build --no-cache -t {Tag-To-Attach-To-Image}  . ``

#### If you want to pass in build-time variables
`` docker build --build-arg VAR=value -t {Tag-To-Attach-To-Image} . ``

#### Remove an image
`` docker rmi {Tag-To-Attach-To-Image}``

#### Prune Images
`` docker image prune``

#### Prune Containers
`` docker container prune``


### Docker run
``docker run {Tag-To-Attach-To-Image} {Optional:Can run commands here for the container i.e. pytest }``

###### Docker run Interactive mode
`` docker run -it {Tag-To-Attach-To-Image} /bin/sh ``
###### Docker run with mounting volume host:container
`` docker run -v "$(pwd)"/test-results:/test-result {Tag-To-Attach-To-Image}  ``
###### Docker run with .env file
`` docker run --env-file ./.env {Tag-To-Attach-To-Image}  ``
###### Docker run with entrypoint
`` docker run --entrypoint {your entrypoint} {Tag-To-Attach-To-Image}  ``

##### Docker Compose build - must be docker Compose V2
`` docker compose build --no-cache``

#### Docker Compose Run
`` docker compose up``


### Lessons learned
- When working with containers, runners and proxies make sure you add these values into the docker run command
```
docker run -e no_proxy=$no_proxy -e HTTP_PROXY=$HTTP_PROXY -e HTTPS_PROXY=$HTTPS_PROXY {Tag-To-Attach-To-Image}
```
